namespace Lab06.Models
{
    public class KntEmployee
    {
        public int KntId { get; set; }
        public string KntName { get; set; } = string.Empty;
        
        public DateTime KntBirthday { get; set; } = DateTime.Now;

        public string KntEmail { get; set; } = string.Empty;
        public string KntPhone { get; set; } = string.Empty;
        public decimal KntSalary { get; set; } = 0.0m;
        public bool KntIsActive { get; set; } = true;
    }
}
