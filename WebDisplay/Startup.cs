using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDisplay.Startup))]
namespace WebDisplay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
