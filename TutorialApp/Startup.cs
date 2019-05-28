using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialApp.Startup))]
namespace TutorialApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
