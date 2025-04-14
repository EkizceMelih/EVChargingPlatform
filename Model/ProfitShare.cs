namespace EVChargingPlatform.Model
{
    public class ProfitShare
    {
        public int ShareId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DistributionDate { get; set; }

    }
}
