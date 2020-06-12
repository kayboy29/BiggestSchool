using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiggestSchool.Startup))]
namespace BiggestSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
