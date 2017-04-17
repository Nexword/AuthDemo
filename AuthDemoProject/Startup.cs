using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthDemoProject.Startup))]
namespace AuthDemoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
