using System;
using System.IO;
using log4net;
using LocalMediaManager.Configuration.Contracts;
using LocalMediaManager.Logging;
using Newtonsoft.Json;

namespace LocalMediaManager.Configuration
{
    public class JsonConfigurationBuilder : IConfigurationBuilder
    {
        private ILog _logger;

        public JsonConfigurationBuilder(ILogger logger)
        {
            _logger = logger.GetLogger(GetType());
        }

        public Configuration BuildConfiguration(string configLocation)
        {
            try
            {
                string configurationJson = File.ReadAllText(configLocation);
                Configuration configuration = JsonConvert.DeserializeObject<Configuration>(configurationJson);
                _logger.Info("Configuration read");
                return configuration;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
