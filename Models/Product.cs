using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalWarehouseAPI.Models
{
    [Table("products")]
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public int ZoneId { get; set; }
    }
}