using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Service1.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Service1Controller : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("http://localhost:6002/Service2");
            var result = await response.Result.Content.ReadAsStringAsync();
            
            return Ok(result);
        }
    }
}