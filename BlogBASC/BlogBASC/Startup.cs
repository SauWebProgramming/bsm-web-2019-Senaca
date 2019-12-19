using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogBASC.Startup))]
namespace BlogBASC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
