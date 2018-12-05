using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TnTPZK.Startup))]
namespace TnTPZK
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
