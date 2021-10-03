using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azbus
{
    public static class win32_processor_atr
    {
        public const string stmt_query_processor = "SELECT * " +
                                                   "FROM   Win32_Processor";
        
        public const string stmt_query_ram = "SELECT *" +
                                             "FROM   Win32_PhysicalMemory";
        
        public const string stmt_query_hardDisk = "SELECT * " +
                                                  "FROM   Win32_LogicalDisk";
        
        public const string stmt_query_motherboard = "SELECT * " +
                                                     "FROM   Win32_MotherboardDevice";
        
        public const string stmt_query_graphics = "SELECT *" +
                                                  "FROM   Win32_VideoController";
        
        public const string stmt_query_operatingSystem = "SELECT *" +
                                                          "FROM   Win32_OperatingSystem";        
    }
}
