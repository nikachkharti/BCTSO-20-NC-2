using System.Linq.Expressions;

namespace University.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        ///TODO: დაამატეთ Paging
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, string includeProperties = null);

        ///TODO: დაამატეთ Paging
        Task<List<T>> GetAllAsync(string includeProperties = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, string includeProperties = null);
        Task AddAsync(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
