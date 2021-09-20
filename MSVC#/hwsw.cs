﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Collections;

namespace azbus
{
    public class hwsw
    {        

        private const string stmt_query_processor = "SELECT * " +
                                                    "FROM   Win32_Processor";

        private const string stmt_query_ram = "SELECT *" +
            "                                  FROM   Win32_PhysicalMemory";

        private const string stmt_query_hardDisk = "SELECT * " +
                                                   "FROM   Win32_LogicalDisk";

        private const string stmt_query_motherboard = "SELECT * " +
                                                      "FROM   Win32_MotherboardDevice";

        private const string stmt_query_graphics = "SELECT *" +
                                                   "FROM   Win32_VideoController";

        private const string stmt_query_operatingSystem = "SELECT *" +
                                                          "FROM   Win32_OperatingSystem";


        private ManagementObjectSearcher mgmt_os = default(ManagementObjectSearcher);

        private ManagementObjectCollection mgmt_oc = default(ManagementObjectCollection);

        public hwsw()
        {}

        /* BEGIN OS */
        public string get_osAll()
        {
            return this.getValues(stmt_query_operatingSystem);
        }
        /* END OS*/

        /*BEGIN GRAPHICS*/

        public string get_graphicsAll()
        {
            return this.getValues(stmt_query_graphics);
        }
        /* END GRAPHICS*/

        /* BEGIN HARD DISK*/
        public string get_storageAll()
        {
            return this.getValues(stmt_query_hardDisk);
        }

        /* END HARD DISK*/

        /* BEGIN MOTHERBOARD */
        public string get_motherboardAll() 
        {
            return this.getValues(stmt_query_motherboard);
        }

        /* END MOTHERBOARD*/

        /* BEGIN RAM*/
        public string get_ramAll()
        {
            return this.getValues(stmt_query_ram);
        }

        /* END RAM*/

        /* BEGIN CPU */
        public string get_CpuAll()
        {
            return this.getValues(stmt_query_processor);
        }

        public string getCpuUsage()
        {
            
            this.build_query(stmt_query_processor);

            try
            {

                foreach (ManagementObject xbase in this.mgmt_oc)
                {
                    return xbase["LoadPercentage"].ToString();
                }

            }catch(Exception e)
            {
                return "Error en proceso, contacte al Desarrollador. Error: GCU -> "+e.Message.ToString();
            }

            return "NO_DATA_FOUND";
            
        }
        /*  END CPU */

        /*GLOBAL*/
        private void build_query(string pQuery)
        {
            this.mgmt_os = new ManagementObjectSearcher(pQuery);

            this.mgmt_oc = this.mgmt_os.Get();
        }

        private string getValues(string pQuery) {

            string retVal = null;

            this.build_query(pQuery);

            foreach (ManagementObject xbase in this.mgmt_oc)
            {
                foreach (var z in xbase.Properties)
                {
                    if (z.Value != null)
                    {

                        if ((z.Value.ToString().Trim() != "") && (!z.Name.ToString().Contains("ClassName")))
                        {
                            retVal = retVal + "-> "+z.Name + " = " + z.Value + "\n";
                        }
                    }
                }
            }

            return retVal;
        }

    }


}
