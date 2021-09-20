using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;

namespace azbus
{
    public partial class Form1 : Form
    {
        hwsw hwInfo;
        Thread th1;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Az-Bus Hardware & Software Info by @ChecheSwap";
            this.StartPosition = FormStartPosition.CenterScreen;            
            this.MaximizeBox = false;

            this.th1 = new Thread(this.runx) { 
                IsBackground = true             
            };

            this.hwInfo = new hwsw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                       

            this.rtbCpu.Text = this.hwInfo.get_CpuAll();

            this.rtbram.Text = this.hwInfo.get_ramAll();

            this.rtbmotherboard.Text = this.hwInfo.get_motherboardAll();

            this.rtbstorage.Text = this.hwInfo.get_storageAll();
            
            this.rtbgraphics.Text = this.hwInfo.get_graphicsAll();

            this.rtbos.Text = this.hwInfo.get_osAll();
            
            this.th1.Start();


        }

        private void runx() {

            hwsw hwlocal = new hwsw();
            string x;

            while (true) { 

                x = "CPU Utilization: " + hwlocal.getCpuUsage() + "%";

                this.lblCpuUsage.Invoke(new MethodInvoker(delegate ()
                {                                       
                    this.lblCpuUsage.Text = x;
                }));                
               
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AZ-BUS Hardware & Software Info. V1.00","AZ-BUS by @ChecheSwap", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
