using Microsoft.AspNetCore.Mvc;
using DigitalWarehouseAPI.Data;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WarehouseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("zones")]
        public IActionResult GetZones()
        {
            var zones = _context.Zones.ToList();

            return Ok(zones);
        }
    }
}