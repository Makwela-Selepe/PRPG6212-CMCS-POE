namespace CMCS_PROG6212_POE.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; } = "";
        public string Month { get; set; } = "";
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalAmount => HoursWorked * HourlyRate;
        public string Status { get; set; } = "Pending";
        public string Description { get; set; } = "";
    }
}
