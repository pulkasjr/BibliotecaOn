using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppBiblioteca.Startup))]
namespace WebAppBiblioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
