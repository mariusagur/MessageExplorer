using System;
using System.Collections.Generic;

namespace MessageExplorer.Models
{
    public class MessageHierarchyModel
    {
        public MessageHierarchyModel()
        {
            Entities = new Dictionary<string, bool>();
            Messages = new Dictionary<MessageModel, bool>();
            Subscribers = new List<SubscriberModel>();
        }
        public Dictionary<string, bool> Entities { get; set; }
        public Dictionary<MessageModel, bool> Messages { get; set; }
        public List<SubscriberModel> Subscribers { get; set; }
    }
}
