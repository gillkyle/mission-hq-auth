using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissionAuth.Startup))]
namespace MissionAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
