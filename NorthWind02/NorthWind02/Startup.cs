using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthWind02.Startup))]
namespace NorthWind02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
