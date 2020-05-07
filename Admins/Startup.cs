using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admins.Startup))]
namespace Admins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
