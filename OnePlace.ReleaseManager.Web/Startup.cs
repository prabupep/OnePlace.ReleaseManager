using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnePlace.ReleaseManager.Web.Startup))]
namespace OnePlace.ReleaseManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
