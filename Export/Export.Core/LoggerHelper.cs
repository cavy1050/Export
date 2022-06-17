﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;
namespace Export.Core
{

    public static class LoggerHelper
    {
        //private static ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static ILog log = log4net.LogManager.GetLogger("日志");

        /// <summary>
        /// 获取当前 Ilog 对象
        /// </summary>
        public static ILog GetILog
        {
            get
            {
                return log;
            }
        }
        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public static void Error(object message, Exception ex)
        {
            log.Error(message, ex);
        }
        /// <summary>
        /// 记录严重错误
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public static void Fatal(object message, Exception ex)
        {
            log.Fatal(message, ex);
        }
        /// <summary>
        /// 记录一般信息
        /// </summary>
        /// <param name="message"></param>
        public static void Info(object message)
        {
            log.Info(message);
        }
        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="message"></param>
        public static void Debug(object message)
        {
            log.Debug(message);
        }
        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="message"></param>
        public static void Warn(object message)
        {
            log.Warn(message);
        }
    }
}
