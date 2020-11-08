using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop_Auth.Startup))]
namespace WebShop_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
