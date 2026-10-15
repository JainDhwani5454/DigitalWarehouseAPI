public class Zone
{
    public int Id { get; set; }

    public string ZoneName { get; set; } = string.Empty;

    public int Capacity { get; set; }

    public int Occupied { get; set; }

    public decimal Utilization { get; set; }
}