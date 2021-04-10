using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Server_project.Startup))]

namespace Server_project
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new Microsoft.AspNet.SignalR.HubConfiguration();
            config.EnableJSONP = true;

            app.MapSignalR(config);
        }
    }
}
