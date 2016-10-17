using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oppo.Startup))]
namespace oppo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
