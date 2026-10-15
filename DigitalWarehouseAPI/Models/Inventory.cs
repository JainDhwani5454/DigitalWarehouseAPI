using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalWarehouseAPI.Models
{
    [Table("inventory")]
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int ZoneId { get; set; }

        public int TotalStock { get; set; }

        public int LowStockThreshold { get; set; }

        public bool OutOfStock { get; set; }
    }
}