using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication001.Startup))]
namespace WebApplication001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
