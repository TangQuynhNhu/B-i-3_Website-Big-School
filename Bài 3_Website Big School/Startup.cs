using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bài_3_Website_Big_School.Startup))]
namespace Bài_3_Website_Big_School
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
