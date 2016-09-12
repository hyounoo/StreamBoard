using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StreamBoard.Startup))]
namespace StreamBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
