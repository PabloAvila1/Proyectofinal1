using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyectofinal1.Startup))]
namespace Proyectofinal1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
