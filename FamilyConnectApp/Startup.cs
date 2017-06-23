using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyConnectApp.Startup))]
namespace FamilyConnectApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
