using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MrCasting.Web.Startup))]
namespace MrCasting.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
