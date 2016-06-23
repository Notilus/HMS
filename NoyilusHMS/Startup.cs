using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotilusHMS.Startup))]
namespace NotilusHMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
