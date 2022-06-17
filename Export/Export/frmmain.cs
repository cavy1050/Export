using Export.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Export
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        static string _FromConnectionString = "";
        static string _ftpServer = "";
        static string _UploadPath = "";
        static string _TitleStr = "";
        static string _UP_State = "";
        private void But_Export_Click(object sender, EventArgs e)
        {
            try
            {
                string _ksrq = dTP_Ksrq.Value.ToString("yyyyMMdd");
                string _jsrq = dTP_Jsrq.Value.ToString("yyyyMMdd");
                int r = 0;
                for (int i = 0; i < ckLB_SJ.Items.Count; i++)
                {
                    if (ckLB_SJ.GetItemChecked(i))
                    {
                        r++;
                    }
                }
                if (r == 0)
                {
                    MessageBox.Show("未选择需要导出的数据，请选择");
                    ckLB_SJ.Focus();
                    return;
                }
                string _Result = Export.Utility.Export.ExportData(_FromConnectionString, ckLB_SJ, _ksrq, _jsrq);
                if (!string.IsNullOrEmpty(_Result))
                {
                    String[] _result = _Result.Split('&');
                    _UploadPath = _result[0];
                    _TitleStr = _result[1];
                    dTP_Ksrq.Enabled = false;
                    dTP_Jsrq.Enabled = false;
                    ckLB_SJ.Enabled = false;
                    But_Upload.Enabled = true;
                    But_Export.Enabled = false;
                }
                else
                {
                    MessageBox.Show("导出数据失败，请查看日志导出失败原因处理后，再次导出");
                    ckLB_SJ.Focus();
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Error(ex.Message, ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void But_Upload_Click(object sender, EventArgs e)
        {
            try
            {

                string _ksrq = dTP_Ksrq.Value.ToString("yyyyMMdd");
                string _jsrq = dTP_Jsrq.Value.ToString("yyyyMMdd");
                string _Result = Export.Utility.Export.UploadFtp(_ftpServer, _UploadPath, _TitleStr, _ksrq, _jsrq);
                if (!string.IsNullOrEmpty(_Result))
                {
                    MessageBox.Show(_Result);
                    dTP_Ksrq.Enabled = true;
                    dTP_Jsrq.Enabled = true;
                    ckLB_SJ.Enabled = true;
                    But_Upload.Enabled = false;
                    But_Export.Enabled = true;

                }
                else
                {
                    MessageBox.Show("上传FTP文件失败,失败原因,请查看日志");
                    ckLB_SJ.Focus();
                }
                _UploadPath = "";
                _TitleStr = "";
            }
            catch (Exception ex)
            {
                LoggerHelper.Error(ex.Message, ex);
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmtest_Load(object sender, EventArgs e)
        {
            try
            {
                But_Upload.Enabled = false;
                But_Export.Enabled = true;
                _FromConnectionString = ConfigurationManager.AppSettings["ForConnectionString"];
                _ftpServer = ConfigurationManager.AppSettings["FtpServer"];
                String[] _ConnectionString = _FromConnectionString.Split('|');
                foreach (var item in _ConnectionString)
                {
                    string _ProcStr = ConfigurationManager.ConnectionStrings[item].ProviderName.ToString();
                    String[] _procStr = _ProcStr.Split('|');
                    ckLB_SJ.Items.Add(_procStr[1]);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Error(ex.Message, ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void Tm_DateTime_Tick(object sender, EventArgs e)
        {
            label5.Text = "当前时间：" + DateTime.Now.ToString() + "";
        }
        void TM_Upload(string _ksrq, string _jsrq)
        {

            string _Result=Export.Utility.Export.ExportData(_FromConnectionString, ckLB_SJ, _ksrq, _jsrq);
            if (!string.IsNullOrEmpty(_Result))
            {
                String[] _result = _Result.Split('&');
                _UploadPath = _result[0];
                _TitleStr = _result[1];
                //Export.Utility.Export.UploadFtp(_ftpServer, _UploadPath, _TitleStr, _ksrq, _jsrq);
            }
        }
        private void Tm_DtZX_Tick(object sender, EventArgs e)
        {

            try
            {
                string now = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
                string dateTerm = null;//项目剩余时间
                TimeSpan ts1 = new TimeSpan(DateTime.Now.Ticks);//将日期转化为可以比较的类型  
                TimeSpan ts2 = new TimeSpan(dateTimePicker1.Value.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();//结束日期减去当前日期  
                dateTerm = "距离下次数据上传还有" + ts.Days.ToString() + "天"
                        + ts.Hours.ToString() + "小时"
                        + ts.Minutes.ToString() + "分"
                        + ts.Seconds.ToString() + "秒";
                lab_msg.Text = dateTerm;//显示在Label里  
                if (now == dateTimePicker1.Value.ToString("yyyyMMdd HH:mm:ss"))
                {
                    if (rdBut_M.Checked == true)
                    {
                        TM_Upload(dateTimePicker1.Value.AddMonths(-1).AddDays(-1).ToString("yyyyMMdd"),
                            dateTimePicker1.Value.AddDays(-1).ToString("yyyyMMdd"));

                        dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
                    }
                    if (rdBut_D.Checked == true)
                    {
                        TM_Upload(dateTimePicker1.Value.AddDays(-1).ToString("yyyyMMdd"),
                            dateTimePicker1.Value.AddDays(-1).ToString("yyyyMMdd"));

                        dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Error("定时执行错误", ex);
            }
        }

        private void But_Start_Click(object sender, EventArgs e)
        {
            try
            {
                int r = 0;
                for (int i = 0; i < ckLB_SJ.Items.Count; i++)
                {
                    if (ckLB_SJ.GetItemChecked(i))
                    {
                        r++;
                    }
                }
                if (r == 0)
                {
                    MessageBox.Show("未选择需要的数据，请选择");
                    ckLB_SJ.Focus();
                    return;
                }
                if (rdBut_M.Checked == false && rdBut_D.Checked == false)
                {
                    MessageBox.Show("请选择时间传输类型(按天/按月)！");
                    return;
                }
                DateTime nowDt = DateTime.Now;
                if (dateTimePicker1.Value.CompareTo(nowDt) < 0)
                {
                    if (rdBut_M.Checked == true)
                    {
                        dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
                    }
                    if (rdBut_D.Checked == true)
                    {
                        dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
                    }
                    _UP_State = "T";
                }
                Tm_DtZX.Enabled = true;
                dTP_Ksrq.Enabled = false;
                dTP_Jsrq.Enabled = false;
                dateTimePicker1.Enabled = false;
                rdBut_M.Enabled = false;
                rdBut_D.Enabled = false;
                ckLB_SJ.Enabled = false;
                But_Export.Enabled = false;
                But_Upload.Enabled = false;
                But_Start.Enabled = false;
                But_Stop.Enabled = true;
            }
            catch (Exception ex)
            {
                LoggerHelper.Error("定时执行错误", ex);
            }
        }

        private void But_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (_UP_State == "T")
                {
                    if (rdBut_M.Checked == true)
                    {
                        dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
                    }
                    if (rdBut_D.Checked == true)
                    {
                        dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
                    }
                    _UP_State = "";
                }
                lab_msg.Text = "距离下次数据上传还有0天00小时00分00秒";
                Tm_DtZX.Enabled = false;
                dTP_Ksrq.Enabled = true;
                dTP_Jsrq.Enabled = true;
                ckLB_SJ.Enabled = true;
                dateTimePicker1.Enabled = true;
                rdBut_M.Enabled = true;
                rdBut_D.Enabled = true;
                But_Export.Enabled = true;
                But_Start.Enabled = true;
                But_Upload.Enabled = false;
                But_Stop.Enabled = false;
            }
            catch (Exception ex)
            {
                LoggerHelper.Error("定时停止错误", ex);
            }
        }

        private void tsp_Show_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void tsp_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
        }
        private void frmmain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
