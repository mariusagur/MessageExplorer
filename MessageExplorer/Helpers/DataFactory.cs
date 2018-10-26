using MessageExplorer.Helpers;
using MessageExplorer.Models;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;
using System.Linq;
using static MessageExplorer.Helpers.Constants;

namespace MessageExplorer
{
    public class DataFactory
    {
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
            foreach (var message in messages)
            {
                _model.Messages.Add(EntityMapper.MapMessageModelFromEntity(message), false);
            }

            foreach (var workflow in workflows)
            {
                var subscribers = EntityMapper.MapSubscriberFromWorkflow(workflow, _model.Messages.Keys.ToList());
                subscribers.ForEach(s =>
                {
                    AddSubscriber(s);
                });
            }

            foreach (var plugin in plugins)
            {
                var subscriber = EntityMapper.MapSubscriberFromPlugin(plugin, _model.Messages.Keys.ToList());
                AddSubscriber(subscriber);
            }
        }

        private void AddSubscriber(SubscriberModel subscriber)
        {
            _model.Entities[subscriber.Entity] = true;
            _model.Messages[subscriber.Message] = true;
            _model.Subscribers.Add(subscriber);
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
            // State values
            // 0: Draft, 1: Activated
            qe.Criteria.AddCondition("statecode", ConditionOperator.Equal, 1);
            // Types values 
            // 1: Definition, 2: Activation, 3: Template
            qe.Criteria.AddCondition("type", ConditionOperator.Equal, 1);
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
                ColumnSet = new ColumnSet("name", AttributeFilter, SdkMessageFilterRelatedEntityAttribute)
            };
            qe.Criteria.AddCondition(SdkMessageFilterRelatedEntityAttribute, ConditionOperator.NotNull);
            qe.Criteria.AddCondition(HiddenAttribute, ConditionOperator.Equal, false);
            var result = Service.RetrieveMultiple(qe);

            return result.Entities.ToArray();
        }
    }
}
