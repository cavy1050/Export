using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Export.Core
{
    public class SQLHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// Data Source=数据库地址;Initial Catalog=数据库名称;Persist Security Info=True;User ID=用户名;Password=密码
        /// </summary>
        private string _SqlConnectionStr = "";

        public string SqlConnectionStr { get { return _SqlConnectionStr; } }
        public SQLHelper(string connStr)
        {
            this._SqlConnectionStr = connStr;
        }
        #region 单值查询      
        public string GetSingle(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    try
                    {
                        conn.Open();
                        return String.Format("{0}", cmd.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public string GetSingle(string sqlStr, SqlParameter[] cmdParams)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlStr;
                        cmd.Parameters.AddRange(cmdParams);
                        return String.Format("{0}", cmd.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion

        #region 查询数据集        
        public DataSet Query(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlDataAdapter ada = new SqlDataAdapter(sqlStr, conn))
                {
                    try
                    {
                        conn.Open();
                        DataSet ds = new DataSet();
                        ada.Fill(ds);
                        return ds;
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public DataSet Query(string sqlStr, SqlParameter[] cmdParams)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = sqlStr;
                            cmd.Parameters.AddRange(cmdParams);

                            DataSet ds = new DataSet();
                            ada.Fill(ds);
                            return ds;
                        }
                        catch (SqlException e)
                        {
                            throw e;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
        public DataSet RunProcedure(string procName, SqlParameter[] cmdParams)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = procName;
                            cmd.Parameters.AddRange(cmdParams);

                            DataSet ds = new DataSet();
                            ada.Fill(ds);
                            return ds;
                        }
                        catch (SqlException e)
                        {
                            throw e;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
        #endregion

        #region 单表查询
        public DataTable GetQueryData(string sqlStr)
        {
            DataSet ds = Query(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public DataTable GetQueryData(string sqlStr, SqlParameter[] cmdParams)
        {
            DataSet ds = Query(sqlStr, cmdParams);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public DataTable GetProcData(string procName, SqlParameter[] cmdParams)
        {
            DataSet ds = RunProcedure(procName, cmdParams);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        #endregion

        #region 单行查询       
        public DataRow GetQueryRecord(string sqlStr)
        {
            DataTable dt = GetQueryData(sqlStr);
            if (dt != null && dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
        public DataRow GetQueryRecord(string sqlStr, SqlParameter[] cmdParams)
        {
            DataTable dt = GetQueryData(sqlStr, cmdParams);
            if (dt != null && dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
        public DataRow GetProcRecord(string procName, SqlParameter[] cmdParams)
        {
            DataTable dt = GetProcData(procName, cmdParams);
            if (dt != null && dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
        #endregion

        #region 使用完应关闭Reader
        public SqlDataReader ExecuteReader(string sqlStr)
        {
            SqlConnection conn = new SqlConnection(this._SqlConnectionStr);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public SqlDataReader ExecuteReeder(string sqlStr, SqlParameter[] cmdParams)
        {
            SqlConnection conn = new SqlConnection(this._SqlConnectionStr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                cmd.Parameters.AddRange(cmdParams);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        #endregion

        #region 执行sql语句        
        public int ExecuteSql(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public int ExecuteSql(string sqlStr, SqlParameter[] cmdParams)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                    
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlStr;
                        cmd.Parameters.AddRange(cmdParams);
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion

        #region 执行事务        
        public int ExecuteSqlTran(List<string> sqlStrList)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = tran;
                            conn.Open();
                            int count = 0;
                            foreach (string sql in sqlStrList)
                            {
                                cmd.CommandText = sql;
                                count += cmd.ExecuteNonQuery();
                            }
                            tran.Commit();
                            return count;
                        }
                        catch (SqlException e)
                        {
                            tran.Rollback();
                            throw e;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
        public int ExecuteSqlTran(List<KeyValuePair<string, SqlParameter[]>> sqlStrList)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = tran;
                            conn.Open();
                            int count = 0;
                            foreach (var item in sqlStrList)
                            {
                                cmd.CommandText = item.Key;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddRange(item.Value);
                                count += cmd.ExecuteNonQuery();
                            }
                            tran.Commit();
                            return count;
                        }
                        catch (SqlException e)
                        {
                            tran.Rollback();
                            throw e;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
        public int ExecuteProc(string procName, SqlParameter[] cmdParams)
        {
            using (SqlConnection conn = new SqlConnection(this._SqlConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = procName;
                        cmd.Parameters.AddRange(cmdParams);
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion
    }
}
