using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication.MVC.Startup))]
namespace WebApplication.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
