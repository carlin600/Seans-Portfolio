using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarlinMotorRepairs.Startup))]
namespace CarlinMotorRepairs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
