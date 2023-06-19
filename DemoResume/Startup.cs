using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoResume.Startup))]
namespace DemoResume
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
