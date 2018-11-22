using MessageExplorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageExplorer.Helpers
{
    public class ExportFormatter
    {
        public static string BuildContent(List<SubscriberModel> subscribers, params string[] attributes)
        {
            var content = new Dictionary<string, object>();
            foreach (var s in subscribers)
            {
                
                foreach (var a in attributes)
                {

                }
            }

            throw new NotImplementedException();

        }
    }
}
