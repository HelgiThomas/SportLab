using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sportlab.Startup))]
namespace Sportlab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
