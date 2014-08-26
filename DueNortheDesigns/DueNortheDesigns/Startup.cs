using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DueNortheDesigns.Startup))]
namespace DueNortheDesigns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
