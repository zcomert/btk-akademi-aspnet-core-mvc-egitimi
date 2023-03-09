namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
    }
}