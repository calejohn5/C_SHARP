using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final.Startup))]
namespace Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
