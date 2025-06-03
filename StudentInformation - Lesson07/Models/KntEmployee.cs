namespace EmployeeInformation___Lesson07.Models
{
    public class KntEmployee
    {
        public int KntId { get; set; }
        public string KntName { get; set; } = string.Empty;
        public DateTime KntBirthday { get; set; }
        public string KntEmail { get; set; } = string.Empty;
        public string KntPhone { get; set; } = string.Empty;
        public decimal KntSalary { get; set; }
        public bool KntIsActive { get; set; } = true;
    }
}
