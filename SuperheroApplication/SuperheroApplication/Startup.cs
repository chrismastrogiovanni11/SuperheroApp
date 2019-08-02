using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperheroApplication.Startup))]
namespace SuperheroApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
