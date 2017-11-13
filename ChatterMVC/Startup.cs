using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterMVC.Startup))]
namespace ChatterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
