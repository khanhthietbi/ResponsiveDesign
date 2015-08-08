using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Responsive.Startup))]
namespace Responsive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
