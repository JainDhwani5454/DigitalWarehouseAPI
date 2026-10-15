using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : ControllerBase
    {
        [HttpGet("map")]
        public IActionResult GetMap()
        {
            return Ok("API Working");
        }
    }
}