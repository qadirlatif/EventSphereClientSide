using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventSphere.Startup))]
namespace EventSphere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           
        }
    }
}
