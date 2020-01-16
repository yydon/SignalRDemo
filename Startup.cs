using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRDemo.SignalR.Startup))]

namespace SignalRDemo.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}