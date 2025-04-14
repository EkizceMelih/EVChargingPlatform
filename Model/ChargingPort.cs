namespace EVChargingPlatform.Model
{
    public class ChargingPort
    {

        public int PortId { get; set; }
        public int StationId { get; set; }
        public int PortNumber { get; set; }
        public string Type { get; set; } // AC / DC
        public decimal PowerKw { get; set; }
        public string Status { get; set; } // Available, In Use, Maintenance

    }
}
