namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String? CategoryName { get; set; } = String.Empty;
        
        // Collection navigation property
        public ICollection<Product> Products { get; set; }  
    }
}