using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalWarehouseAPI.Models
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}