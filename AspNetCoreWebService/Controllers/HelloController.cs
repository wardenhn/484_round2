using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebService.Controllers
{
    [Route("/")]
    public class HelloController : Controller
    {
        private const string MESSAGE_FORMAT = "Hello {0}!";

        [HttpGet]
        public JsonResult Get([FromQuery] string name = "World")
        {
            return Json(new Response
            {
                output = string.Format(MESSAGE_FORMAT, name)
            });
        }

        [HttpPost]
        public JsonResult Post([FromBody]string name = "World")
        {
            return Json(new Response
            {
                output = string.Format(MESSAGE_FORMAT, name)
            });
        }
    }
}
