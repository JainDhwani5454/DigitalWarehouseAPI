namespace DigitalWarehouseAPI.Services
{
    public class WarehouseService
    {
        public object GetWarehouseMap()
        {
            return new[]
            {
                new
                {
                    Zone = "Zone A",
                    Occupancy = 30,
                    Color = "Green"
                },
                new
                {
                    Zone = "Zone B",
                    Occupancy = 70,
                    Color = "Yellow"
                },
                new
                {
                    Zone = "Zone C",
                    Occupancy = 90,
                    Color = "Red"
                }
            };
        }
    }
}
