using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNBUM.UI.Startup))]
namespace UNBUM.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
