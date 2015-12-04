using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace LocalMediaManager.Logging
{
    public class Logger : ILogger
    {
        public Logger(string logFileLocation)
        {
            if (!LogManager.GetRepository().Configured)
            {
                FileInfo loggerConfig = new FileInfo(logFileLocation);
                XmlConfigurator.ConfigureAndWatch(loggerConfig);
            }
        }

        public ILog GetLogger(string loggerName)
        {
            ILog logger = LogManager.GetLogger(loggerName);
            return logger;
        }

        public ILog GetLogger(Type loggerName)
        {
            ILog logger = LogManager.GetLogger(loggerName);
            return logger;
        }
    }
}
