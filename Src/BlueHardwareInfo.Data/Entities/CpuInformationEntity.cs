using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueHardwareInfo.Data.Entities
{
    public class CpuInformationEntity
    {
        public string Architecture { get; set; }
        public string Caption { get; set; }
        public string Family { get; set; }
        public string ProcessorId { get; set; }
        public string Name { get; set; }
        public int MaxClockSpeed { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfLogicalProcessors { get; set; }
        public int L2CacheSize { get; set; }
    }//end class
}
