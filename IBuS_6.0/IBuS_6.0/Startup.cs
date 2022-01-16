using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBuS_6._0.Startup))]
namespace IBuS_6._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
