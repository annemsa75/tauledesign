using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tauledesign.Startup))]
namespace tauledesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
