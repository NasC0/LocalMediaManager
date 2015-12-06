using System;
using System.ServiceProcess;
using LocalMediaManager.Configuration.Contracts;
using LocalMediaManager.Logging;
using log4net;
using StructureMap;
//using LocalMediaManager.WebApi;

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
                    //new WebApiService()
                };

                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
