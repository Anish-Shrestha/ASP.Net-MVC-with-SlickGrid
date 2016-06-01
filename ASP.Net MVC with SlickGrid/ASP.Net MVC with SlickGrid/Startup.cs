using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.Net_MVC_with_SlickGrid.Startup))]
namespace ASP.Net_MVC_with_SlickGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
