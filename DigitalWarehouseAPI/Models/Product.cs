namespace DigitalWarehouseAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
    }
}