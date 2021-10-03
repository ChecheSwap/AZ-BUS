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
    public partial class formBase : Form
    {
        hwsw hwInfo;
        Thread th1;
        public formBase()
        {
            InitializeComponent();
            this.Text = Program.application_title;
            this.StartPosition = FormStartPosition.CenterScreen;            
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
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

            this.processThread(true);

        }

        private void processThread(Boolean cbstatus) {

            if (!cbstatus)
            {
                if (this.th1 != null)
                {

                    this.lblCpuUsage.Visible = false;

                    this.progressBar1.Visible = false;

                    this.Height = 710;

                    this.th1.Abort();

                    this.th1 = null;


                }                
            }
            else
            {
                this.th1 = new Thread(this.runx)
                {
                    IsBackground = true
                };
                this.th1.Start();

                this.lblCpuUsage.Visible = true;

                this.progressBar1.Visible = true;

                this.Height = 744;

            }
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
            MessageBox.Show(Program.azbus_version,Program.application_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbcpu_CheckedChanged(object sender, EventArgs e)
        {

           this.processThread(this.cbcpu.Checked);

        }
    }
}
