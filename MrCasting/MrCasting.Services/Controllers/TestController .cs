using System.Collections.Generic;
using System.Web.Http;

namespace MrCasting.Services.Impl
{
    public class TestController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new[] { "Working!!" };
        }

        public string Get(int id)
        {
            return "Working!!!";
        }
    }
}
