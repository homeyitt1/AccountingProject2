using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountingProject2.Startup))]
namespace AccountingProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
