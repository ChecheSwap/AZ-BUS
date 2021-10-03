
namespace azbus
{
    partial class formBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBase));
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCpu = new System.Windows.Forms.TabPage();
            this.rtbCpu = new System.Windows.Forms.RichTextBox();
            this.tabRam = new System.Windows.Forms.TabPage();
            this.rtbram = new System.Windows.Forms.RichTextBox();
            this.tcontrolmobo = new System.Windows.Forms.TabPage();
            this.rtbmotherboard = new System.Windows.Forms.RichTextBox();
            this.tabAlmacenamiento = new System.Windows.Forms.TabPage();
            this.rtbstorage = new System.Windows.Forms.RichTextBox();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.rtbgraphics = new System.Windows.Forms.RichTextBox();
            this.tabSo = new System.Windows.Forms.TabPage();
            this.rtbos = new System.Windows.Forms.RichTextBox();
            this.ImagesForTabs = new System.Windows.Forms.ImageList(this.components);
            this.panelBack = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnamefooter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbcpu = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabCpu.SuspendLayout();
            this.tabRam.SuspendLayout();
            this.tcontrolmobo.SuspendLayout();
            this.tabAlmacenamiento.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.tabSo.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuUsage.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsage.ForeColor = System.Drawing.Color.White;
            this.lblCpuUsage.Location = new System.Drawing.Point(42, 623);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(30, 32);
            this.lblCpuUsage.TabIndex = 2;
            this.lblCpuUsage.Text = "*";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCpu);
            this.tabControl.Controls.Add(this.tabRam);
            this.tabControl.Controls.Add(this.tcontrolmobo);
            this.tabControl.Controls.Add(this.tabAlmacenamiento);
            this.tabControl.Controls.Add(this.tabVideo);
            this.tabControl.Controls.Add(this.tabSo);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.ImagesForTabs;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 40);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(643, 451);
            this.tabControl.TabIndex = 3;
            // 
            // tabCpu
            // 
            this.tabCpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCpu.Controls.Add(this.rtbCpu);
            this.tabCpu.ImageIndex = 0;
            this.tabCpu.Location = new System.Drawing.Point(4, 44);
            this.tabCpu.Name = "tabCpu";
            this.tabCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabCpu.Size = new System.Drawing.Size(635, 403);
            this.tabCpu.TabIndex = 0;
            this.tabCpu.Text = "CPU";
            this.tabCpu.UseVisualStyleBackColor = true;
            this.tabCpu.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rtbCpu
            // 
            this.rtbCpu.BackColor = System.Drawing.Color.Blue;
            this.rtbCpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCpu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCpu.ForeColor = System.Drawing.Color.White;
            this.rtbCpu.Location = new System.Drawing.Point(6, 6);
            this.rtbCpu.Name = "rtbCpu";
            this.rtbCpu.ReadOnly = true;
            this.rtbCpu.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbCpu.Size = new System.Drawing.Size(619, 387);
            this.rtbCpu.TabIndex = 0;
            this.rtbCpu.Text = "";
            // 
            // tabRam
            // 
            this.tabRam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRam.Controls.Add(this.rtbram);
            this.tabRam.ImageIndex = 1;
            this.tabRam.Location = new System.Drawing.Point(4, 44);
            this.tabRam.Name = "tabRam";
            this.tabRam.Padding = new System.Windows.Forms.Padding(3);
            this.tabRam.Size = new System.Drawing.Size(635, 403);
            this.tabRam.TabIndex = 5;
            this.tabRam.Text = "RAM";
            this.tabRam.UseVisualStyleBackColor = true;
            // 
            // rtbram
            // 
            this.rtbram.BackColor = System.Drawing.Color.Blue;
            this.rtbram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbram.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbram.ForeColor = System.Drawing.Color.White;
            this.rtbram.Location = new System.Drawing.Point(6, 6);
            this.rtbram.Name = "rtbram";
            this.rtbram.ReadOnly = true;
            this.rtbram.Size = new System.Drawing.Size(619, 387);
            this.rtbram.TabIndex = 1;
            this.rtbram.Text = "";
            // 
            // tcontrolmobo
            // 
            this.tcontrolmobo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcontrolmobo.Controls.Add(this.rtbmotherboard);
            this.tcontrolmobo.ImageIndex = 2;
            this.tcontrolmobo.Location = new System.Drawing.Point(4, 44);
            this.tcontrolmobo.Name = "tcontrolmobo";
            this.tcontrolmobo.Padding = new System.Windows.Forms.Padding(3);
            this.tcontrolmobo.Size = new System.Drawing.Size(635, 403);
            this.tcontrolmobo.TabIndex = 1;
            this.tcontrolmobo.Text = "Motherboard";
            this.tcontrolmobo.UseVisualStyleBackColor = true;
            // 
            // rtbmotherboard
            // 
            this.rtbmotherboard.BackColor = System.Drawing.Color.Blue;
            this.rtbmotherboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbmotherboard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbmotherboard.ForeColor = System.Drawing.Color.White;
            this.rtbmotherboard.Location = new System.Drawing.Point(6, 6);
            this.rtbmotherboard.Name = "rtbmotherboard";
            this.rtbmotherboard.ReadOnly = true;
            this.rtbmotherboard.Size = new System.Drawing.Size(619, 387);
            this.rtbmotherboard.TabIndex = 1;
            this.rtbmotherboard.Text = "";
            // 
            // tabAlmacenamiento
            // 
            this.tabAlmacenamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAlmacenamiento.Controls.Add(this.rtbstorage);
            this.tabAlmacenamiento.ImageIndex = 3;
            this.tabAlmacenamiento.Location = new System.Drawing.Point(4, 44);
            this.tabAlmacenamiento.Name = "tabAlmacenamiento";
            this.tabAlmacenamiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlmacenamiento.Size = new System.Drawing.Size(635, 403);
            this.tabAlmacenamiento.TabIndex = 2;
            this.tabAlmacenamiento.Text = "Storage";
            this.tabAlmacenamiento.UseVisualStyleBackColor = true;
            // 
            // rtbstorage
            // 
            this.rtbstorage.BackColor = System.Drawing.Color.Blue;
            this.rtbstorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbstorage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbstorage.ForeColor = System.Drawing.Color.White;
            this.rtbstorage.Location = new System.Drawing.Point(6, 6);
            this.rtbstorage.Name = "rtbstorage";
            this.rtbstorage.ReadOnly = true;
            this.rtbstorage.Size = new System.Drawing.Size(619, 387);
            this.rtbstorage.TabIndex = 2;
            this.rtbstorage.Text = "";
            // 
            // tabVideo
            // 
            this.tabVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabVideo.Controls.Add(this.rtbgraphics);
            this.tabVideo.ImageIndex = 4;
            this.tabVideo.Location = new System.Drawing.Point(4, 44);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(635, 403);
            this.tabVideo.TabIndex = 3;
            this.tabVideo.Text = "Graphics";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // rtbgraphics
            // 
            this.rtbgraphics.BackColor = System.Drawing.Color.Blue;
            this.rtbgraphics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbgraphics.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbgraphics.ForeColor = System.Drawing.Color.White;
            this.rtbgraphics.Location = new System.Drawing.Point(6, 6);
            this.rtbgraphics.Name = "rtbgraphics";
            this.rtbgraphics.ReadOnly = true;
            this.rtbgraphics.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbgraphics.Size = new System.Drawing.Size(619, 387);
            this.rtbgraphics.TabIndex = 2;
            this.rtbgraphics.Text = "";
            // 
            // tabSo
            // 
            this.tabSo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabSo.Controls.Add(this.rtbos);
            this.tabSo.ImageIndex = 5;
            this.tabSo.Location = new System.Drawing.Point(4, 44);
            this.tabSo.Name = "tabSo";
            this.tabSo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSo.Size = new System.Drawing.Size(635, 403);
            this.tabSo.TabIndex = 4;
            this.tabSo.Text = "Operating System";
            this.tabSo.UseVisualStyleBackColor = true;
            // 
            // rtbos
            // 
            this.rtbos.BackColor = System.Drawing.Color.Blue;
            this.rtbos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbos.ForeColor = System.Drawing.Color.White;
            this.rtbos.Location = new System.Drawing.Point(6, 6);
            this.rtbos.Name = "rtbos";
            this.rtbos.ReadOnly = true;
            this.rtbos.Size = new System.Drawing.Size(619, 387);
            this.rtbos.TabIndex = 2;
            this.rtbos.Text = "";
            // 
            // ImagesForTabs
            // 
            this.ImagesForTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesForTabs.ImageStream")));
            this.ImagesForTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesForTabs.Images.SetKeyName(0, "cpu.png");
            this.ImagesForTabs.Images.SetKeyName(1, "ram.png");
            this.ImagesForTabs.Images.SetKeyName(2, "motherboard.png");
            this.ImagesForTabs.Images.SetKeyName(3, "hdd.png");
            this.ImagesForTabs.Images.SetKeyName(4, "video.ico");
            this.ImagesForTabs.Images.SetKeyName(5, "mswindows.png");
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.tabControl);
            this.panelBack.Location = new System.Drawing.Point(43, 150);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(640, 452);
            this.panelBack.TabIndex = 4;
            // 
            // panellogo
            // 
            this.panellogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellogo.BackgroundImage")));
            this.panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogo.Location = new System.Drawing.Point(160, 47);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(419, 97);
            this.panellogo.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "mstrip";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DimGray;
            this.panelFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFooter.BackgroundImage")));
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 665);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(728, 40);
            this.panelFooter.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblnamefooter);
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Rights Reserved";
            // 
            // lblnamefooter
            // 
            this.lblnamefooter.AutoSize = true;
            this.lblnamefooter.BackColor = System.Drawing.Color.Transparent;
            this.lblnamefooter.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamefooter.ForeColor = System.Drawing.Color.Red;
            this.lblnamefooter.Location = new System.Drawing.Point(5, 3);
            this.lblnamefooter.Name = "lblnamefooter";
            this.lblnamefooter.Size = new System.Drawing.Size(273, 15);
            this.lblnamefooter.TabIndex = 1;
            this.lblnamefooter.Text = "Developed By Jesús José Navarrete Baca";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(565, 634);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            // 
            // cbcpu
            // 
            this.cbcpu.AutoSize = true;
            this.cbcpu.BackColor = System.Drawing.Color.Transparent;
            this.cbcpu.Checked = true;
            this.cbcpu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbcpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbcpu.Location = new System.Drawing.Point(565, 609);
            this.cbcpu.Name = "cbcpu";
            this.cbcpu.Size = new System.Drawing.Size(112, 17);
            this.cbcpu.TabIndex = 9;
            this.cbcpu.Text = "Show CPU Usage";
            this.cbcpu.UseVisualStyleBackColor = false;
            this.cbcpu.CheckedChanged += new System.EventHandler(this.cbcpu_CheckedChanged);
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 705);
            this.Controls.Add(this.cbcpu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panellogo);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.lblCpuUsage);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formBase";
            this.Text = "formCentral";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCpu.ResumeLayout(false);
            this.tabRam.ResumeLayout(false);
            this.tcontrolmobo.ResumeLayout(false);
            this.tabAlmacenamiento.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            this.tabSo.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCpu;
        private System.Windows.Forms.TabPage tcontrolmobo;
        private System.Windows.Forms.TabPage tabAlmacenamiento;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabSo;
        private System.Windows.Forms.RichTextBox rtbCpu;
        private System.Windows.Forms.TabPage tabRam;
        private System.Windows.Forms.ImageList ImagesForTabs;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnamefooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox rtbram;
        private System.Windows.Forms.RichTextBox rtbmotherboard;
        private System.Windows.Forms.RichTextBox rtbstorage;
        private System.Windows.Forms.RichTextBox rtbgraphics;
        private System.Windows.Forms.RichTextBox rtbos;
        private System.Windows.Forms.CheckBox cbcpu;
    }
}

