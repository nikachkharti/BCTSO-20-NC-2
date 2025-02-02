using MiniBank.Models;

namespace MiniBank.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerAsync(int id);
        Task<int> CreateAsync(Customer customer);
        Task<int> UpdateAsync(Customer customer);
        Task<int> DeleteAsync(int id);

        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
