namespace EVChargingPlatform.Model
{
    public class ChargingSession
    {


        public int SessionId { get; set; }
        public int UserId { get; set; }
        public int StationId { get; set; }
        public int PortId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal EnergyUsedKWh { get; set; }
        public decimal BaseCost { get; set; }
        public decimal DiscountApplied { get; set; }
        public decimal FinalCost { get; set; }
        public string PaymentStatus { get; set; } // Pending, Completed, Failed

    }
}
