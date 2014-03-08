using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RacerDomo.Startup))]
namespace RacerDomo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
