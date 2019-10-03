using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace DevKSoft.Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class LogService
    {
        private ILog _log;

        public LogService(ILog log)
        {
            _log = log;
        }

        public bool InInfoEnable => _log.IsInfoEnabled;
        public bool InDebugEnable => _log.IsDebugEnabled;
        public bool InWarnEnable => _log.IsWarnEnabled;
        public bool InFatalEnable => _log.IsFatalEnabled;
        public bool InErrorEnable => _log.IsErrorEnabled;

        public void Info(object logMessage)
        {
            if (InInfoEnable)
            {
                _log.Info(logMessage);
            }
        }

        public void Debug(object logMessage)
        {
            if (InDebugEnable)
            {
                _log.Debug(logMessage);
            }
        }

        public void Warn(object logMessage)
        {
            if (InWarnEnable)
            {
                _log.Warn(logMessage);
            }
        }

        public void Fatal(object logMessage)
        {
            if (InFatalEnable)
            {
                _log.Fatal(logMessage);
            }
        }

        public void Error(object logMessage)
        {
            if (InErrorEnable)
            {
                _log.Error(logMessage);
            }
        }
    }
}
