using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMercury.Startup))]
namespace ProjectMercury
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
