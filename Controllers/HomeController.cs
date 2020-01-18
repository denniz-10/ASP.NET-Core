using Microsoft.AspNetCore.Mvc;

namespace ASP_NET.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
    }
}