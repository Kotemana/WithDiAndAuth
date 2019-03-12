using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WithAuthAndDi.Startup))]
namespace WithAuthAndDi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
