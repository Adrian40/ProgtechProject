using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoKolcsonzoApp.Startup))]
namespace AutoKolcsonzoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
