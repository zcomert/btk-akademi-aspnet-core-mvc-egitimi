using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "ProductName is required.")]
    public String? ProductName { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Price is required.")]
    public decimal Price { get; set; }

    public int? CategoryId { get; set; }        // Foreign Key
    public Category? Category { get; set; }     // Navigation property
}
