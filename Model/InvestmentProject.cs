namespace EVChargingPlatform.Model
{
    public class InvestmentProject
    {

        public int ProjectId { get; set; }
        public int StationId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal CollectedFunds { get; set; }
        public string Status { get; set; } // Open, Funded, Cancelled
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
