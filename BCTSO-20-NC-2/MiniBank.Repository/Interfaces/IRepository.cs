using System.Data;

namespace MiniBank.Repository.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<IEnumerable<T>> GetAll(string query, CommandType commandType, Dictionary<string, object> parameters = null);
        Task<T> Get(string query, CommandType commandType, Dictionary<string, object> parameters = null);
        Task<int> Execute(string query, CommandType commandType, Dictionary<string, object> parameters = null);
    }
}
