using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSnoop.Models
{
    class SqlServerCpuUtilization
    {
        public int SqlCpuUtilization { get; set; }
        public int SystemIdleProcess { get; set; }
        public int OtherCpuUtilization { get; set; }
        public DateTime EventTime { get; set; }
    }
}
