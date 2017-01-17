using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWepSite.Startup))]
namespace MvcWepSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
