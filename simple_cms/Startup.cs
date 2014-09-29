using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(simple_cms.Startup))]
namespace simple_cms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
