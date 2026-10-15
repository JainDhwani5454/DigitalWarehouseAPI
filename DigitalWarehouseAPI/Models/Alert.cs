namespace DigitalWarehouseAPI.Models
{
    public class Alert
    {
        public int Id { get; set; }

        public string Message { get; set; } = string.Empty;

        public string Severity { get; set; } = string.Empty;
    }
}