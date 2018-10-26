using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace MessageExplorer.Models
{
    public class SubscriberModel
    {
        public Guid Id { get; set; }
        public string SubscriberName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SubscriberType Type { get; set; }
        public List<string> AttributeFilter { get; set; }
        public string Entity { get; set; }
        public MessageModel Message { get; set; }


        public enum SubscriberType
        {
            Plugin,
            Workflow
        }
    }
}
