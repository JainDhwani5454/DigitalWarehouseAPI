using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInventory()
        {
            return Ok(new[]
            {
                new
                {
                    Product = "Alumina",
                    Quantity = 500,
                    Zone = "Zone A"
                }
            });
        }
    }
}