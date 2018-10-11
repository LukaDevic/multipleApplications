using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleApplications.Startup))]
namespace MultipleApplications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
