using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageExplorer.Helpers
{
    public static class Constants
    {
        public const string SdkMessageFilterLogicalName = "sdkmessagefilter";
        public const string SdkMessageStepLogicalName = "sdkmessageprocessingstep";
        public const string SdkMessageLogicalName = "sdkmessage";
        public const string SdkMessageFilterTargetEntityAttribute = "primaryobjecttypecode";
        public const string MessageNameLinkAttribute = "message.name";
        public const string CreateTriggerAttribute = "triggeroncreate";
        public const string DeleteTriggerAttribute = "triggerondelete";
        public const string UpdateTriggerAttribute = "triggeronupdateattributelist";
        public const string WorkflowPrimaryEntityAttribute = "primaryentity";
        public const string SdkMessageFilterRelatedEntityAttribute = "sdkmessagefilterid";
        public const string SdkMessageAttribute = "sdkmessageid";
        public const string HiddenAttribute = "ishidden";
        public const string AttributeFilter = "filteringattributes";
        public const string MessageNameProperty = "MessageName";
        public const string MessageEntityProperty = "Entity";
        public const string IdProperty = "Id";
        public const string SubscriberNameProperty = "SubscriberName";
    }
}
