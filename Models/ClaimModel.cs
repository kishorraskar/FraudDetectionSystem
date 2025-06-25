namespace FraudDetectionSystem.Models
{
    public class ClaimModel
    {
        public int ClaimId { get; set; } // Primary Key
        public string PolicyNumber { get; set; }
        public DateTime ClaimDate { get; set; }
        public string PolicyHolderName { get; set; }
        public string BeneficiaryName { get; set; }
        public decimal ClaimAmount { get; set; }
        public string CauseOfClaim { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime LapseDate { get; set; }
        public decimal InsuredAmount { get; set; }
        public string ClaimStatus { get; set; }
        public bool FraudIndicator { get; set; } // True = Fraud detected
        public string Notes { get; set; }
    }
}
