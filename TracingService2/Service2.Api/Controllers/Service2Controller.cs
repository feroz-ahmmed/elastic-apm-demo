using Microsoft.AspNetCore.Mvc;

namespace Service2.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Service2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Service2";
        }
    }
}