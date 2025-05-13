using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02_Exercise.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
        public bool StillAvaliable { get; set; }
    }
}
