

using Owin;
using Microsoft.Owin;
[assembly:OwinStartup(typeof(SignalRMVC5Chat.Startup))]

namespace SignalRMVC5Chat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}