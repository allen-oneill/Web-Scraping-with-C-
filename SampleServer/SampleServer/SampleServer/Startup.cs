using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleServer.Startup))]
namespace SampleServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
