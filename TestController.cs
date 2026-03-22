
using Microsoft.AspNetCore.Mvc;
using PermissionAuthorization.Attributes;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [HasPermission("Test.Read")]
        public IActionResult Get()
        {
            return Ok("Authorized");
        }
    }
}
