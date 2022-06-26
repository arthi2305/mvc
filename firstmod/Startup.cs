using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstmod.Startup))]
namespace firstmod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
