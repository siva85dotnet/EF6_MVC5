using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF6_MVC5_DB_First.Startup))]
namespace EF6_MVC5_DB_First
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
