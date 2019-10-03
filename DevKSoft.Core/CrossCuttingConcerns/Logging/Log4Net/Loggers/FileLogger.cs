using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace DevKSoft.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class FileLogger:LogService
    {
        public FileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }
    }
}
