using Export.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Export.Utility
{
   public class ExportDAL
    {
        public static System.Data.DataTable GetExecProc(string proc, string ksrq, string jsrq)
        {
            string sql = string.Format("exec " + proc + "'{0}','{1}'", ksrq, jsrq);
            LoggerHelper.Info(sql);
            return SqlConnectionStr.SqlServer.GetQueryData(sql);
        }
    }
    class SqlConnectionStr
    {
        public static string _SqlConnectionStr = null;
        private static string _connStr;
        private static string sqlConnectionStr
        {
            get
            {
                _connStr = _SqlConnectionStr;
                if (_connStr == null)
                    _connStr = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
                return _connStr;
            }

        }
        public static SQLHelper SqlServer
        {
            get
            {
                return new SQLHelper(sqlConnectionStr);
            }
        }
    }
}
