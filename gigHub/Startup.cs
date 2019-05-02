using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gigHub.Startup))]
namespace gigHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
