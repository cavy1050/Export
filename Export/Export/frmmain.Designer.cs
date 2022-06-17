
namespace Export
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.But_Export = new System.Windows.Forms.Button();
            this.dTP_Jsrq = new System.Windows.Forms.DateTimePicker();
            this.dTP_Ksrq = new System.Windows.Forms.DateTimePicker();
            this.But_Upload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckLB_SJ = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBut_M = new System.Windows.Forms.RadioButton();
            this.rdBut_D = new System.Windows.Forms.RadioButton();
            this.lab_msg = new System.Windows.Forms.Label();
            this.But_Stop = new System.Windows.Forms.Button();
            this.But_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Tm_DateTime = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsp_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_DtZX = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // But_Export
            // 
            this.But_Export.Location = new System.Drawing.Point(187, 12);
            this.But_Export.Name = "But_Export";
            this.But_Export.Size = new System.Drawing.Size(75, 23);
            this.But_Export.TabIndex = 0;
            this.But_Export.Text = "导出";
            this.But_Export.UseVisualStyleBackColor = true;
            this.But_Export.Click += new System.EventHandler(this.But_Export_Click);
            // 
            // dTP_Jsrq
            // 
            this.dTP_Jsrq.CustomFormat = "yyyy-MM-dd";
            this.dTP_Jsrq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_Jsrq.Location = new System.Drawing.Point(74, 45);
            this.dTP_Jsrq.Name = "dTP_Jsrq";
            this.dTP_Jsrq.Size = new System.Drawing.Size(83, 21);
            this.dTP_Jsrq.TabIndex = 4;
            // 
            // dTP_Ksrq
            // 
            this.dTP_Ksrq.CustomFormat = "yyyy-MM-dd";
            this.dTP_Ksrq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_Ksrq.Location = new System.Drawing.Point(74, 19);
            this.dTP_Ksrq.Name = "dTP_Ksrq";
            this.dTP_Ksrq.Size = new System.Drawing.Size(83, 21);
            this.dTP_Ksrq.TabIndex = 3;
            // 
            // But_Upload
            // 
            this.But_Upload.Location = new System.Drawing.Point(187, 41);
            this.But_Upload.Name = "But_Upload";
            this.But_Upload.Size = new System.Drawing.Size(75, 23);
            this.But_Upload.TabIndex = 9;
            this.But_Upload.Text = "上传";
            this.But_Upload.UseVisualStyleBackColor = true;
            this.But_Upload.Click += new System.EventHandler(this.But_Upload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.But_Upload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTP_Jsrq);
            this.groupBox1.Controls.Add(this.But_Export);
            this.groupBox1.Controls.Add(this.dTP_Ksrq);
            this.groupBox1.Location = new System.Drawing.Point(121, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(361, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "手工操作";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "结束日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "开始日期：";
            // 
            // ckLB_SJ
            // 
            this.ckLB_SJ.FormattingEnabled = true;
            this.ckLB_SJ.Location = new System.Drawing.Point(19, 42);
            this.ckLB_SJ.Name = "ckLB_SJ";
            this.ckLB_SJ.Size = new System.Drawing.Size(84, 180);
            this.ckLB_SJ.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBut_M);
            this.groupBox2.Controls.Add(this.rdBut_D);
            this.groupBox2.Controls.Add(this.lab_msg);
            this.groupBox2.Controls.Add(this.But_Stop);
            this.groupBox2.Controls.Add(this.But_Start);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(121, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(361, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定时操作";
            // 
            // rdBut_M
            // 
            this.rdBut_M.AutoSize = true;
            this.rdBut_M.Location = new System.Drawing.Point(16, 41);
            this.rdBut_M.Name = "rdBut_M";
            this.rdBut_M.Size = new System.Drawing.Size(329, 16);
            this.rdBut_M.TabIndex = 14;
            this.rdBut_M.TabStop = true;
            this.rdBut_M.Text = "按月(导出传输时间前一个月,但不包括传输当天数据上传)";
            this.rdBut_M.UseVisualStyleBackColor = true;
            // 
            // rdBut_D
            // 
            this.rdBut_D.AutoSize = true;
            this.rdBut_D.Location = new System.Drawing.Point(16, 19);
            this.rdBut_D.Name = "rdBut_D";
            this.rdBut_D.Size = new System.Drawing.Size(215, 16);
            this.rdBut_D.TabIndex = 13;
            this.rdBut_D.TabStop = true;
            this.rdBut_D.Text = "按天(导出传输时间前一天数据上传)";
            this.rdBut_D.UseVisualStyleBackColor = true;
            // 
            // lab_msg
            // 
            this.lab_msg.AutoSize = true;
            this.lab_msg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_msg.ForeColor = System.Drawing.Color.DarkRed;
            this.lab_msg.Location = new System.Drawing.Point(13, 96);
            this.lab_msg.Name = "lab_msg";
            this.lab_msg.Size = new System.Drawing.Size(249, 12);
            this.lab_msg.TabIndex = 12;
            this.lab_msg.Text = "距离下次数据上传还有0天00小时00分00秒\r\n";
            // 
            // But_Stop
            // 
            this.But_Stop.Location = new System.Drawing.Point(270, 91);
            this.But_Stop.Name = "But_Stop";
            this.But_Stop.Size = new System.Drawing.Size(75, 23);
            this.But_Stop.TabIndex = 11;
            this.But_Stop.Text = "停止";
            this.But_Stop.UseVisualStyleBackColor = true;
            this.But_Stop.Click += new System.EventHandler(this.But_Stop_Click);
            // 
            // But_Start
            // 
            this.But_Start.Location = new System.Drawing.Point(270, 62);
            this.But_Start.Name = "But_Start";
            this.But_Start.Size = new System.Drawing.Size(75, 23);
            this.But_Start.TabIndex = 11;
            this.But_Start.Text = "启动";
            this.But_Start.UseVisualStyleBackColor = true;
            this.But_Start.Click += new System.EventHandler(this.But_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "下次传输时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Tm_DateTime
            // 
            this.Tm_DateTime.Enabled = true;
            this.Tm_DateTime.Interval = 1000;
            this.Tm_DateTime.Tick += new System.EventHandler(this.Tm_DateTime_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_Show,
            this.tsp_Exit});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // tsp_Show
            // 
            this.tsp_Show.Name = "tsp_Show";
            this.tsp_Show.Size = new System.Drawing.Size(100, 22);
            this.tsp_Show.Text = "显示";
            this.tsp_Show.Click += new System.EventHandler(this.tsp_Show_Click);
            // 
            // tsp_Exit
            // 
            this.tsp_Exit.Name = "tsp_Exit";
            this.tsp_Exit.Size = new System.Drawing.Size(100, 22);
            this.tsp_Exit.Text = "退出";
            this.tsp_Exit.Click += new System.EventHandler(this.tsp_Exit_Click);
            // 
            // Tm_DtZX
            // 
            this.Tm_DtZX.Interval = 1000;
            this.Tm_DtZX.Tick += new System.EventHandler(this.Tm_DtZX_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Location = new System.Drawing.Point(5, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(112, 225);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据列表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "上传";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(164, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 21);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "导出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(164, 22);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(96, 21);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(122, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "当前时间：0000-00-00 00:00:00";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 256);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckLB_SJ);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export_Server（派出所社会资源数据传输）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.frmtest_Load);
            this.SizeChanged += new System.EventHandler(this.frmmain_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.notifyIconMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Export;
        private System.Windows.Forms.DateTimePicker dTP_Jsrq;
        private System.Windows.Forms.DateTimePicker dTP_Ksrq;
        private System.Windows.Forms.Button But_Upload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ckLB_SJ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBut_M;
        private System.Windows.Forms.RadioButton rdBut_D;
        private System.Windows.Forms.Label lab_msg;
        private System.Windows.Forms.Button But_Stop;
        private System.Windows.Forms.Button But_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer Tm_DateTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem tsp_Show;
        private System.Windows.Forms.ToolStripMenuItem tsp_Exit;
        private System.Windows.Forms.Timer Tm_DtZX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
    }
}