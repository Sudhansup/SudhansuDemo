using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SudhansuDemo.Startup))]
namespace SudhansuDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
