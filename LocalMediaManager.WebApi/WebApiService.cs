using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace LocalMediaManager.WebApi
{
    partial class WebApiService : ServiceBase
    {
        private IDisposable _server;
        
        public WebApiService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            StartOptions options = new StartOptions();
            options.Urls.Add("http://0.0.0.0:1803");
            _server = WebApp.Start<Startup>(options);
        }

        protected override void OnStop()
        {
            _server?.Dispose();

            base.OnStop();
        }
    }
}
