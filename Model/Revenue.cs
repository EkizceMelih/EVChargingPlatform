namespace EVChargingPlatform.Model
{
    public class Revenue
    {

        public int RevenueId { get; set; }
        public int ProjectId { get; set; }
        public decimal TotalRevenue { get; set; }
        public DateTime DistributionDate { get; set; }

    }
}
