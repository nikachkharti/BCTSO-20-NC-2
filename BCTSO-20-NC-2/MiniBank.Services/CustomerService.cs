using MiniBank.Models;
using MiniBank.Repository.Interfaces;
using MiniBank.Services.Interfaces;
using System.Data;

namespace MiniBank.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> GetCustomer(int id)
        {
            string commandText = "spGetSingleCustomer";
            var parameters = new Dictionary<string, object>()
                {
                    {"@customerId",id }
                };

            var result = await _customerRepository.Get(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            string commandText = "spGetAllCustomers";
            var result = await _customerRepository.GetAll(commandText, null, CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
