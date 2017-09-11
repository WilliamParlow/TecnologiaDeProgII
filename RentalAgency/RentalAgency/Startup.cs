using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalAgency.Startup))]
namespace RentalAgency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
