using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HouseRent.Startup))]
namespace HouseRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
