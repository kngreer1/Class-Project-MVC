using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Greer_P1.Startup))]
namespace Greer_P1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
