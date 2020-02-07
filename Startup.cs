using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testTest.Startup))]
namespace testTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
