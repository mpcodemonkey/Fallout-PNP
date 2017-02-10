using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fallout_PNP.Startup))]
namespace Fallout_PNP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
