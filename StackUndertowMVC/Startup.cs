using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StackUndertowMVC.Startup))]
namespace StackUndertowMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
