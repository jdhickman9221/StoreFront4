using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreFront4.Startup))]
namespace StoreFront4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
