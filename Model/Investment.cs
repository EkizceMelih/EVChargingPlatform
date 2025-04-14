namespace EVChargingPlatform.Model
{
    public class Investment
    {
        public int InvestmentId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public decimal Amount { get; set; }
        public decimal Shares { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime InvestmentDate { get; set; }


    }
}
