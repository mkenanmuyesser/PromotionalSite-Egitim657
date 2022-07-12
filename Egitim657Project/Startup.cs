using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Egitim657Project.Startup))]
namespace Egitim657Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
