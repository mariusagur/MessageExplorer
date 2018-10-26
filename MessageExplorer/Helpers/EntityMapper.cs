using MessageExplorer.Models;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;
using static MessageExplorer.Helpers.Constants;

namespace MessageExplorer.Helpers
{
    public class EntityMapper
    {
        public static MessageModel MapMessageModelFromEntity(Entity message)
        {
            return new MessageModel
            {
                Entity = message.GetAttributeValue<string>(SdkMessageFilterTargetEntityAttribute),
                Id = message.Id,
                MessageName = (string)message.GetAttributeValue<AliasedValue>(MessageNameLinkAttribute).Value
            };
        }

        public static List<SubscriberModel> MapSubscriberFromWorkflow(Entity workflow, List<MessageModel> messages)
        {
            var subscriberList = new List<SubscriberModel>();
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

            foreach (var message in workflowMessages)
            {
                var sdkMessage = messages.First(e => e.MessageName == message && e.Entity == primaryEntity);
                var subscriber = new SubscriberModel
                {
                    Entity = primaryEntity,
                    Id = workflow.Id,
                    Message = sdkMessage,
                    SubscriberName = workflow.GetAttributeValue<string>("name"),
                    Type = SubscriberModel.SubscriberType.Workflow
                };
                if (message == "Update" &&
                    !string.IsNullOrWhiteSpace(workflow.GetAttributeValue<string>(UpdateTriggerAttribute)))
                {
                    subscriber.AttributeFilter = workflow.GetAttributeValue<string>(UpdateTriggerAttribute).Split(',').ToList();
                }
                subscriberList.Add(subscriber);
            }

            return subscriberList;
        }

        public static SubscriberModel MapSubscriberFromPlugin(Entity plugin, List<MessageModel> messages)
        {
            var messageId = plugin.GetAttributeValue<EntityReference>(SdkMessageFilterRelatedEntityAttribute).Id;
            var message = messages.First(e => e.Id == messageId);
            var subscriber = new SubscriberModel
            {
                Entity = message.Entity,
                Id = plugin.Id,
                Message = message,
                SubscriberName = plugin.GetAttributeValue<string>("name"),
                Type = SubscriberModel.SubscriberType.Plugin,
            };
            if (string.Equals(message.MessageName, "update", System.StringComparison.InvariantCultureIgnoreCase) &&
                !string.IsNullOrWhiteSpace(plugin.GetAttributeValue<string>(AttributeFilter)))
            {
                subscriber.AttributeFilter = plugin.GetAttributeValue<string>(AttributeFilter).Split(',').ToList();
            }

            return subscriber;
        }
    }
}
