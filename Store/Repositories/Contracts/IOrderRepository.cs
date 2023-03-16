using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders {get;}
        Order? GetOneOrder(int id);
        void Complete(int id);
        void SaveOrder(Order order);
        int NumberOfInProcess {get;}
    }   
}