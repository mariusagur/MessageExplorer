using System;

namespace MessageExplorer.Models
{
    public class MessageModel
    {
        public Guid Id { get; set; }
        public string MessageName { get; set; }
        public string Entity { get; set; }
    }
}
