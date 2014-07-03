using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CataShare.Startup))]
namespace CataShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
