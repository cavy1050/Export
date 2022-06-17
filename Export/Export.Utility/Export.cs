using Export.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Export.Utility
{
    public class Export
    {
        #region 导出数据功能
        public static string ExportData(string _FromConnectionString, CheckedListBox CheckedItems, string _ksrq,string _jsrq)
        {
            try
            {
                string  _FliePath = "";
                string _UploadPath = "";
                string _TitleStr = "";
                string _ProcStr = "";
                bool msgstr = false;
                FileHelper.FlieExists("UploadFile");
                FileHelper.DelectDir("UploadFile");
                String[] _ConnectionString = _FromConnectionString.Split('|');
                foreach (var item in _ConnectionString)
                {
                    foreach (string ckstr in CheckedItems.CheckedItems)
                    {
                        SqlConnectionStr._SqlConnectionStr = ConfigurationManager.ConnectionStrings[item].ConnectionString;
                        _ProcStr = ConfigurationManager.ConnectionStrings[item].ProviderName.ToString();
                        String[] _procStr = _ProcStr.Split('|');
                        string _exportproc = _procStr[0];
                        string _exporttitle = _procStr[1];
                        if (ckstr == _exporttitle)
                        {
                            DataTable dataTable = ExportDAL.GetExecProc(_exportproc, _ksrq, _jsrq);
                            _FliePath = "UploadFile\\" + _ksrq + "_" + _jsrq + "（" + _exporttitle + "数据）.csv";
                            LoggerHelper.Info(_FliePath);
                            msgstr = CsvHelper.datatableToCSV(dataTable, _FliePath);
                            if (!msgstr)
                            {
                                LoggerHelper.Info("" + _exporttitle + "导出失败，请重新导出");
                            }
                            else { 
                                _UploadPath += _FliePath + "|";
                                _TitleStr += _exporttitle + "、";
                            }

                        }
                    }
                }
                if (!string.IsNullOrEmpty(_UploadPath))
                {
                    _UploadPath = _UploadPath.Substring(0, _UploadPath.Length - 1);
                    _TitleStr = _TitleStr.Substring(0, _TitleStr.Length - 1);
                }
                LoggerHelper.Info("导出（" + _TitleStr + "）数据成功");
                return _UploadPath+"&"+_TitleStr;
            }
            catch (Exception ex)
            {
                LoggerHelper.Error(ex.Message,ex);
                return "";
            }

        }
        #endregion

        #region 本地导出文件上传FTP功能
        public static string UploadFtp(string _ftpServer, string _UploadPath,string _TitleStr, string _ksrq, string _jsrq)
        {


            String[] _FtpServer = _ftpServer.Split('|');
            string[] Strs = _UploadPath.Split('|');
            FtpHelper ftpHelper = new FtpHelper(_FtpServer[0], _FtpServer[1], _FtpServer[2], _FtpServer[3]);
            string _Msg = "";
            foreach (string word in Strs)
            {
                ftpHelper.Upload(word);
                _Msg += word;
            }
            FileHelper.DelectDir("UploadFile");
            LoggerHelper.Info("上传" + _ksrq + "-" + _jsrq + "( " + _TitleStr + " )数据成功");
            return "上传" + _ksrq + "-" + _jsrq + "( " + _TitleStr + " )数据成功";
        }
        #endregion
    }
}
