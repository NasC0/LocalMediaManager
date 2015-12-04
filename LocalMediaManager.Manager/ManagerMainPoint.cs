using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using LocalMediaManager.Configuration.Contracts;
using LocalMediaManager.Logging;
using StructureMap;

namespace LocalMediaManager.Manager
{
    static class ManagerMainPoint
    {
        private const string AppSettingsLocation = "../../Config/AppSettings.json";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                Container container = Bindings.BindDependencies();
                ILogger logger = container.GetInstance<ILogger>();
                IConfigurationBuilder configBuilder = container.GetInstance<IConfigurationBuilder>();
                var configuration = configBuilder.BuildConfiguration(AppSettingsLocation);

                ILog apiAppender = logger.GetLogger("Api");
                apiAppender.Info("Second teehee");

                ILog rootLogger = LogManager.GetLogger("FileManager");
                rootLogger.Info("Third teehee!");
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {

                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
