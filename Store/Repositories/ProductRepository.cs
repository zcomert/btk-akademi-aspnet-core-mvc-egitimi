using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        // Interface
        public Product? GetOneProduct(int id, bool trackChanges)
        {
              return FindByCondition(p => p.ProductId.Equals(id),trackChanges);  
        }
        
    }
}