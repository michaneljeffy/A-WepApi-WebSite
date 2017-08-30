using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace RedBox.Common.Log
{
    public class NLogLogger : ILogger
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Debug(string message, Exception ex)
        {
            logger.Debug(ex,message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(string message, Exception ex)
        {
            logger.Error(ex, message);
        }

        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public void Fatal(string message, Exception ex)
        {
            logger.Fatal(ex, message);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Info(string message, Exception ex)
        {
            logger.Info(ex, message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        public void Warn(string message, Exception ex)
        {
            logger.Warn(ex, message);
        }
    }
}
