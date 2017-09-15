using Microsoft.Owin;
using Owin;
using System.Web.Http;
 
[assembly: OwinStartup(typeof(URMAC_Server.Authentication.Startup))]
namespace URMAC_Server.Authentication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

    }
}
