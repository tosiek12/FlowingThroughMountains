using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowingThroughMountains.Startup))]
namespace FlowingThroughMountains
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
