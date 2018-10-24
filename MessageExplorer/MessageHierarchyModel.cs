using System;
using System.Collections.Generic;

namespace MessageExplorer
{
    public class MessageHierarchyModel
    {
        public MessageHierarchyModel()
        {
            Entities = new Dictionary<string, bool>();
            Messages = new Dictionary<string, List<KeyValuePair<Guid, string>>>();
            Subscribers = new Dictionary<Guid, List<string>>();
        }
        public Dictionary<string, bool> Entities { get; set; }
        public Dictionary<string, List<KeyValuePair<Guid, string>>> Messages { get; set; }
        public Dictionary<Guid, List<string>> Subscribers { get; set; }
    }
}
