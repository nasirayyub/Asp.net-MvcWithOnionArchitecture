using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppArchitecture.Startup))]
namespace MVCAppArchitecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
