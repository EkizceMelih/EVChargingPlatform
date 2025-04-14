namespace EVChargingPlatform.Model
{
    public class ChargingStation
    {

        public int StationId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Provider { get; set; }
        public int TotalPorts { get; set; }
        public int AvailablePorts { get; set; }
        public decimal PricePerKWh { get; set; }
        public string OpenHours { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
