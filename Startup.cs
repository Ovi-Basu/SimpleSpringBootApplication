using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSpringBootApplication.Startup))]
namespace SimpleSpringBootApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
