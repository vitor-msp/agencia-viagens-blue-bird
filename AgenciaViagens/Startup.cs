using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgenciaViagens.Startup))]
namespace AgenciaViagens
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
