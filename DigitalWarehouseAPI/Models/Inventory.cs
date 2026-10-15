namespace DigitalWarehouseAPI.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int ZoneId { get; set; }

        public int Quantity { get; set; }
    }
}