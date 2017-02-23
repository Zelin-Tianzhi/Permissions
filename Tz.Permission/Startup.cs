using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tz.Permission.Startup))]
namespace Tz.Permission
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
