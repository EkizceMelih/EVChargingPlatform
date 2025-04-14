namespace EVChargingPlatform.Model
{
    public class Payment
    {

        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public int SessionId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // Credit Card, Wallet, Cash
        public string PaymentStatus { get; set; } // Success, Failed, Pending
        public DateTime TransactionTime { get; set; }
    }
}
