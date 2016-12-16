using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppForms.Startup))]
namespace AppForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
