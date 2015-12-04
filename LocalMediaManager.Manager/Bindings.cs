using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalMediaManager.Configuration;
using LocalMediaManager.Configuration.Contracts;
using LocalMediaManager.Logging;
using StructureMap;

namespace LocalMediaManager.Manager
{
    public static class Bindings
    {
        private const string ConfigFolderLocation = "../../Config/";
        private const string Log4NetConfigFile = "log4net.config";

        public static Container BindDependencies()
        {
            Container container = new Container(c =>
            {
                c.For<ILogger>()
                    .Use<Logger>()
                    .Ctor<string>()
                    .Is(ConfigFolderLocation + Log4NetConfigFile);

                c.For<IConfigurationBuilder>()
                    .Use<JsonConfigurationBuilder>();
            });

            return container;
        }
    }
}
