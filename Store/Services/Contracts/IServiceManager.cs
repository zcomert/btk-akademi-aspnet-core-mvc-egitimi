namespace Services.Contracts
{
    public interface IServiceManager
    {
        IProductService ProductService {get;}
        ICategoryService CategoryService {get;}
        IOrderService OrderService {get;}
    }
}