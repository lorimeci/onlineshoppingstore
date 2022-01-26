using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlineshoppingstore.Startup))]
namespace onlineshoppingstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
