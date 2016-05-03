using System.Web.Http;

namespace MrCasting.Services.WebApi.Test.Setup
{
    public class StartupBase
    {
        protected static HttpConfiguration GetConfiguration() {
            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            return config;
        }       
    }
}
