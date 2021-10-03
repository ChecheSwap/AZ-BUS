using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azbus
{
    static class Program
    {
        public static string azbus_version = "Az-Bus Hardware & Software Info V 1.2 \n Date: 03/10/2021";

        public static string application_title = "Az-Bus Hardware & Software Info by @ChecheSwap";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formBase());
        }
    }
}
