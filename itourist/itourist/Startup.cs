using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(itourist.Startup))]
namespace itourist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
