namespace FraudDetectionSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long ContactNumber {  get; set; }
        public string PoliccyNumber { get; set; }
    }
}
