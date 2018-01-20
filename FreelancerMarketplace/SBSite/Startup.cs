using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBSite.Startup))]
namespace SBSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
