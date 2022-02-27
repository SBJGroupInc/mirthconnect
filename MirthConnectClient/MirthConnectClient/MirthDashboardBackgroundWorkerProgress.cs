using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirthConnectClient
{
    public class MirthDashboardBackgroundWorkerProgress
    {
        public int Progress { get; set; }
        public int Max { get; set; }
        public string Message{ get; set; }
        public List<MirthDashboardInfo> NewData { get; set; }

    }
}
