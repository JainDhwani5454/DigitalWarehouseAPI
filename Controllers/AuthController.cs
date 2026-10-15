using DigitalWarehouseAPI.Data;
using DigitalWarehouseAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _context.Users.FirstOrDefault(u =>
                u.EmployeeId == request.EmployeeId &&
                u.Password == request.Password);

            if (user == null)
            {
                return Unauthorized("Invalid Employee ID or Password");
            }

            return Ok(new
            {
                user.EmployeeId,
                user.Email,
                user.Role
            });
        }
    }
}