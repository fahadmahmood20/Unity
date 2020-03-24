using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnityDIMVC.Startup))]
namespace UnityDIMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
