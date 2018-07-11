using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApplicationWithIndAuth.Startup))]
namespace MVCApplicationWithIndAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
