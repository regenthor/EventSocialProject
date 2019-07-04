using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventSocialProject.Startup))]
namespace EventSocialProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
