namespace DigitalWarehouseAPI.Models
{
    public class LoginRequest
    {
        public string EmployeeId { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}