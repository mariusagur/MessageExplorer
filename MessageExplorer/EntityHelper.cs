using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageExplorer
{
    public class EntityHelper
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
        private readonly IOrganizationService Service;

        public EntityHelper(IOrganizationService service)
        {
            Service = service;
        }

        public MessageHierarchyModel GetData()
        {
            var model = new MessageHierarchyModel();
            var workflows = GetWorkflows();
            var messages = GetMessages();
            var plugins = GetPlugins();

            var uniqueEntities = messages.Select(e => e.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute)).Distinct();
            model.Entities = uniqueEntities.ToDictionary(m => m, m => false);
            foreach (var message in messages)
            {
                var entityCode = message.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute);
                if (!model.Messages.ContainsKey(entityCode))
                {
                    model.Messages.Add(entityCode, new List<KeyValuePair<Guid, string>>());
                }
                model.Messages[entityCode].Add(new KeyValuePair<Guid, string>(message.Id, (string)message.GetAttributeValue<AliasedValue>(MessageNameLinkAttribute).Value));
            }

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
                model.Entities[primaryEntity] = true;
                var sdkMessages = model.Messages[primaryEntity];

                foreach (var message in workflowMessages)
                {
                    var sdkMessage = sdkMessages.First(e => e.Value == message);

                    if (!model.Subscribers.ContainsKey(sdkMessage.Key))
                    {
                        model.Subscribers.Add(sdkMessage.Key, new List<string>());
                    }

                    model.Subscribers[sdkMessage.Key].Add($"{workflow.GetAttributeValue<string>("name")} (Workflow)");
                }
            }

            foreach (var plugin in plugins)
            {
                var messageId = plugin.GetAttributeValue<EntityReference>(SdkMessageFilterRelatedEntityAttribute).Id;
                var message = messages.First(e => e.Id == messageId);
                var entityName = message.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute);

                model.Entities[entityName] = true;

                if (!model.Subscribers.ContainsKey(messageId))
                {
                    model.Subscribers.Add(messageId, new List<string>());
                }
                model.Subscribers[messageId].Add($"{plugin.GetAttributeValue<string>("name")} (Plugin)");
            }

            return model;
        }

        private Entity[] GetMessages()
        {
            var qe = new QueryExpression(SdkMessageFilterLogicalName)
            {
                ColumnSet = new ColumnSet(new[] { SdkMessageFilterTargetEntityAttribute })
            };
            var sdkMessageLink = new LinkEntity(SdkMessageFilterLogicalName, SdkMessageLogicalName, SdkMessageAttribute, SdkMessageAttribute, JoinOperator.Inner)
            {
                Columns = new ColumnSet(new[] { "name" }),
                EntityAlias = "message"
            };
            qe.LinkEntities.Add(sdkMessageLink);

            var results = Service.RetrieveMultiple(qe);

            return results.Entities.ToArray();
        }

        private Entity[] GetWorkflows()
        {
            var qe = new QueryExpression("workflow")
            {
                ColumnSet = new ColumnSet("name", UpdateTriggerAttribute, CreateTriggerAttribute, DeleteTriggerAttribute, WorkflowPrimaryEntityAttribute)
            };
            qe.Criteria = new FilterExpression(LogicalOperator.Or);
            qe.Criteria.AddCondition(new ConditionExpression(UpdateTriggerAttribute, ConditionOperator.NotNull));
            qe.Criteria.AddCondition(new ConditionExpression(CreateTriggerAttribute, ConditionOperator.Equal, true));
            qe.Criteria.AddCondition(new ConditionExpression(DeleteTriggerAttribute, ConditionOperator.Equal, true));
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
