using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheWarehouse.WebUI.Startup))]
namespace TheWarehouse.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
