using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalWarehouseAPI.Models
{
    [Table("alerts")]
    public class Alert
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string AlertType { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}