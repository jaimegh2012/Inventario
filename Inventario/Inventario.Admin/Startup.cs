using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inventario.Admin.Startup))]
namespace Inventario.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
