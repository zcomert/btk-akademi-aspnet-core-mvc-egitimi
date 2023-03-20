using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/1.jpg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/2.jpg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/4.jpg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/5.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/6.jpg", ProductName = "History", Price = 25, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/7.jpg", ProductName = "Hamlet", Price = 45, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/images/8.jpg", ProductName = "A Doll's House", Price = 145, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 1, ImageUrl = "/images/9.jpg", ProductName = "Blindness", Price = 4445, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 1, ImageUrl = "/images/10.jpg", ProductName = "Boston", Price = 545, ShowCase = true },
                new Product() { ProductId = 11, CategoryId = 1, ImageUrl = "/images/11.jpg", ProductName = "War and Piece", Price = 385, ShowCase = true },
                new Product() { ProductId = 12, CategoryId = 1, ImageUrl = "/images/12.jpg", ProductName = "The Sound of the Mountain", Price = 845, ShowCase = true },
                new Product() { ProductId = 13, CategoryId = 1, ImageUrl = "/images/13.jpg", ProductName = "The Idiot", Price = 415, ShowCase = true },
                new Product() { ProductId = 14, CategoryId = 1, ImageUrl = "/images/14.jpg", ProductName = "The Trial", Price = 325, ShowCase = true },
                new Product() { ProductId = 15, CategoryId = 1, ImageUrl = "/images/15.jpg", ProductName = "Masnavi", Price = 99, ShowCase = true },
                new Product() { ProductId = 16, CategoryId = 1, ImageUrl = "/images/16.jpg", ProductName = "The Magic Mountain", Price = 199, ShowCase = false }
            );
        }
    }
}