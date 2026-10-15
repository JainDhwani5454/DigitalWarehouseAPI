using DigitalWarehouseAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlertController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Alert Controller Working");
        }

        [HttpGet]
        public IActionResult GetAlerts()
        {
            return Ok(_context.Alerts.ToList());
        }
    }
}