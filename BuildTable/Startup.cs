using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildTable.Startup))]
namespace BuildTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
