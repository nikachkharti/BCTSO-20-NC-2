using Example.API.Models.Entity;
using System.Net;

namespace Example.API.Repository
{
    public interface IToDoRepository
    {
        Task<List<Todo>> GetAll();
        Task<Todo> Get(int id);
        Task Add(Todo model);
        Task Update(Todo model);
        Task Delete(int id);
    }
}
