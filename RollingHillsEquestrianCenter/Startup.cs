using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RollingHillsEquestrianCenter.Startup))]
namespace RollingHillsEquestrianCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
