using DigitalWarehouseAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDashboard()
        {
            try
            {
                var totalProducts = _context.Products.Count();

                var totalZones = _context.Zones.Count();

                var totalStock = _context.Inventories
                    .Sum(i => i.TotalStock);

                var lowStockItems = _context.Inventories
                    .Count(i => i.TotalStock <= i.LowStockThreshold
                             && i.TotalStock > 0);

                var outOfStockItems = _context.Inventories
                    .Count(i => i.OutOfStock);

                var activeAlerts = _context.Alerts.Count();

                return Ok(new
                {
                    TotalProducts = totalProducts,
                    TotalZones = totalZones,
                    TotalStock = totalStock,
                    LowStockItems = lowStockItems,
                    OutOfStockItems = outOfStockItems,
                    ActiveAlerts = activeAlerts
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
