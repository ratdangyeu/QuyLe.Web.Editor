using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuyLe.Web.Editor.Startup))]
namespace QuyLe.Web.Editor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
