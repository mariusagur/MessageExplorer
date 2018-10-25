using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageExplorer
{
    public class DataFactory
    {
        #region constants
        private const string SdkMessageFilterLogicalName = "sdkmessagefilter";
        private const string SdkMessageStepLogicalName = "sdkmessageprocessingstep";
        private const string SdkMessageLogicalName = "sdkmessage";
        private const string SdkMessageFilterTargetEntityAttribute = "primaryobjecttypecode";
        private const string MessageNameLinkAttribute = "message.name";
        private const string CreateTriggerAttribute = "triggeroncreate";
        private const string DeleteTriggerAttribute = "triggerondelete";
        private const string UpdateTriggerAttribute = "triggeronupdateattributelist";
        private const string WorkflowPrimaryEntityAttribute = "primaryentity";
        private const string SdkMessageFilterRelatedEntityAttribute = "sdkmessagefilterid";
        private const string SdkMessageAttribute = "sdkmessageid";
        private const string HiddenAttribute = "ishidden";
        #endregion
        #region local variables
        private readonly IOrganizationService Service;
        private MessageHierarchyModel _model = null;
        #endregion

        public DataFactory(IOrganizationService service)
        {
            Service = service;
        }

        public MessageHierarchyModel Data
        {
            get
            {
                if (_model == null)
                {
                    GetData();
                }
                return _model;
            }
        }

        public void RefreshData()
        {
            _model = null;
        }


        private void GetData()
        {
            _model = new MessageHierarchyModel();
            var workflows = GetWorkflows();
            var messages = GetMessages();
            var plugins = GetPlugins();

            var uniqueEntities = messages.Select(e => e.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute)).Distinct();
            _model.Entities = uniqueEntities.ToDictionary(m => m, m => false);
            ProcessMessages(messages);
            ProcessWorkflows(workflows);
            ProcessPlugins(plugins, messages);
        }

        private void ProcessMessages(Entity[] messages)
        {
            foreach (var message in messages)
            {
                var entityCode = message.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute);
                if (!_model.Messages.ContainsKey(entityCode))
                {
                    _model.Messages.Add(entityCode, new List<KeyValuePair<Guid, string>>());
                }
                _model.Messages[entityCode].Add(new KeyValuePair<Guid, string>(message.Id, (string)message.GetAttributeValue<AliasedValue>(MessageNameLinkAttribute).Value));
            }
        }

        private void ProcessPlugins(Entity[] plugins, Entity[] messages)
        {
            foreach (var plugin in plugins)
            {
                var messageId = plugin.GetAttributeValue<EntityReference>(SdkMessageFilterRelatedEntityAttribute).Id;
                var message = messages.First(e => e.Id == messageId);
                var entityName = message.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute);

                _model.Entities[entityName] = true;

                if (!_model.Subscribers.ContainsKey(messageId))
                {
                    _model.Subscribers.Add(messageId, new List<string>());
                }
                _model.Subscribers[messageId].Add($"{plugin.GetAttributeValue<string>("name")} (Plugin)");
            }
        }

        private void ProcessWorkflows(Entity[] workflows)
        {
            foreach (var workflow in workflows)
            {
                var workflowMessages = new List<string>();
                if (workflow.GetAttributeValue<bool>(CreateTriggerAttribute))
                {
                    workflowMessages.Add("Create");
                }
                if (workflow.GetAttributeValue<bool>(DeleteTriggerAttribute))
                {
                    workflowMessages.Add("Delete");
                }
                if (workflow.GetAttributeValue<object>(UpdateTriggerAttribute) != null)
                {
                    workflowMessages.Add("Update");
                }
                var primaryEntity = workflow.GetAttributeValue<string>(WorkflowPrimaryEntityAttribute);
                _model.Entities[primaryEntity] = true;
                var sdkMessages = _model.Messages[primaryEntity];

                foreach (var message in workflowMessages)
                {
                    var sdkMessage = sdkMessages.First(e => e.Value == message);

                    if (!_model.Subscribers.ContainsKey(sdkMessage.Key))
                    {
                        _model.Subscribers.Add(sdkMessage.Key, new List<string>());
                    }

                    _model.Subscribers[sdkMessage.Key].Add($"{workflow.GetAttributeValue<string>("name")} (Workflow)");
                }
            }
        }

        private Entity[] GetMessages()
        {
            var entityList = new List<Entity>();
            var qe = new QueryExpression(SdkMessageFilterLogicalName)
            {
                ColumnSet = new ColumnSet(new[] { SdkMessageFilterTargetEntityAttribute })
            };
            var sdkMessageLink = new LinkEntity(SdkMessageFilterLogicalName, SdkMessageLogicalName, SdkMessageAttribute, SdkMessageAttribute, JoinOperator.Inner)
            {
                Columns = new ColumnSet(new[] { "name" }),
                EntityAlias = "message"
            };
            //qe.Criteria.AddCondition("iscustomprocessingstepallowed", ConditionOperator.Equal, true);
            qe.LinkEntities.Add(sdkMessageLink);
            qe.PageInfo = new PagingInfo
            {
                PageNumber = 1,
            };
            var results = Service.RetrieveMultiple(qe);

            while (true)
            {
                entityList.AddRange(results.Entities);

                if (results.MoreRecords)
                {
                    qe.PageInfo.PageNumber++;
                    qe.PageInfo.PagingCookie = results.PagingCookie;

                    results = Service.RetrieveMultiple(qe);
                    continue;
                }

                break;
            }

            return entityList.ToArray();
        }

        private Entity[] GetWorkflows()
        {
            var qe = new QueryExpression("workflow")
            {
                ColumnSet = new ColumnSet("name", UpdateTriggerAttribute, CreateTriggerAttribute, DeleteTriggerAttribute, WorkflowPrimaryEntityAttribute)
            };
            qe.Criteria = new FilterExpression(LogicalOperator.And);
            qe.Criteria.AddCondition("statecode", ConditionOperator.Equal, 1);
            var triggerFilter = new FilterExpression(LogicalOperator.Or);
            triggerFilter.AddCondition(UpdateTriggerAttribute, ConditionOperator.NotNull);
            triggerFilter.AddCondition(CreateTriggerAttribute, ConditionOperator.Equal, true);
            triggerFilter.AddCondition(DeleteTriggerAttribute, ConditionOperator.Equal, true);
            qe.Criteria.AddFilter(triggerFilter);
            var result = Service.RetrieveMultiple(qe);

            return result.Entities.ToArray();
        }

        private Entity[] GetPlugins()
        {
            var qe = new QueryExpression(SdkMessageStepLogicalName)
            {
                ColumnSet = new ColumnSet("name", SdkMessageFilterRelatedEntityAttribute)
            };
            qe.Criteria.AddCondition(SdkMessageFilterRelatedEntityAttribute, ConditionOperator.NotNull);
            qe.Criteria.AddCondition(HiddenAttribute, ConditionOperator.Equal, false);
            var result = Service.RetrieveMultiple(qe);

            return result.Entities.ToArray();
        }
    }
}
