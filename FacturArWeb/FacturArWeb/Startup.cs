using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacturArWeb.Startup))]
namespace FacturArWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
