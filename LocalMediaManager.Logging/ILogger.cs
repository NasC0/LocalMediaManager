using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LocalMediaManager.Logging
{
    public interface ILogger
    {
        ILog GetLogger(string loggerName);
        ILog GetLogger(Type loggerName);
    }
}
