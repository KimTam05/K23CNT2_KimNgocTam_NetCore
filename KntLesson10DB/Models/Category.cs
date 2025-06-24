using System.ComponentModel.DataAnnotations.Schema;

namespace KntLesson10DB.Models
{
    [Table("Category")]
    public class Category
    {
        public int CateId { get; set; } = 0;
        public string CateName { get; set; } = null!;
        public bool CateStatus { get; set; } = true;
    }
}
