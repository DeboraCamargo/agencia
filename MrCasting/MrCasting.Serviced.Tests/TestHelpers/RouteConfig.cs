using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace MrCasting.Services.Tests.TestHelpers
{
    class RouteConfig
    {
        internal static void RegisterApiRoutes(HttpSelfHostConfiguration config)
        {
            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
            new { id = RouteParameter.Optional });            
        }
    }
}
