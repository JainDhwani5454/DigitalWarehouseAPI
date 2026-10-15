using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZoneController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetZone(int id)
        {
            return Ok(new
            {
                Id = id,
                ZoneName = "Zone A",
                Capacity = 1000,
                Occupied = 500
            });
        }
    }
}