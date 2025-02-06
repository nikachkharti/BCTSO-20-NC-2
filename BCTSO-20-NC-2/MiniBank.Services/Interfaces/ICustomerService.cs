using MiniBank.Models;

namespace MiniBank.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int id);
    }
}
