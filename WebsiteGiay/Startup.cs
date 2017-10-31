using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteGiay.Startup))]
namespace WebsiteGiay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
