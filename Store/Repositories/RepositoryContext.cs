using System.Reflection;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // modelBuilder.ApplyConfiguration(new ProductConfig());
            // modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
