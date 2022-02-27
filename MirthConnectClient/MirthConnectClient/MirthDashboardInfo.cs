using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirthConnectClient
{
    public class MirthDashboardInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Source{ get; set; }
        public string Destinations { get; set; }
        public long QueuedMessages{ get; set; }
        public DateTime? LastMessage { get; set; }
    }
}
