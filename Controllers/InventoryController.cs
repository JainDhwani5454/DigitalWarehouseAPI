using DigitalWarehouseAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInventory()
        {
            return Ok(_context.Inventories.ToList());
        }
    }
}