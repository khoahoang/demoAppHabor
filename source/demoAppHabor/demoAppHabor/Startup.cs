using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoAppHabor.Startup))]
namespace demoAppHabor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
