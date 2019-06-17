using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(WebConSignalR.Startup))]
namespace WebConSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}