namespace DigitalWarehouseAPI.Services
{
    public class OccupancyService
    {
        public string GetColor(int occupancy)
        {
            if (occupancy > 80)
                return "Red";

            if (occupancy > 50)
                return "Yellow";

            return "Green";
        }
    }
}