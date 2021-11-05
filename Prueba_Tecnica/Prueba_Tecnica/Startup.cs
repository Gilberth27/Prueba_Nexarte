using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_Tecnica.Startup))]
namespace Prueba_Tecnica
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
