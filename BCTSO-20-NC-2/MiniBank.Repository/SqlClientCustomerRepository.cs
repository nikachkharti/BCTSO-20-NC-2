using MiniBank.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using MiniBank.Repository.Interfaces;

namespace MiniBank.Repository
{
    public class SqlClientCustomerRepository : ICustomerRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCTSO20N;Trusted_Connection=true;TrustServerCertificate=true";
        private readonly IRepository<Customer> _repository;

        public SqlClientCustomerRepository()
        {
            _repository = new Repositroy<Customer>(_connectionString);
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            string commandText = "spGetAllCustomers";
            var result = await _repository.GetAll(commandText, null, CommandType.StoredProcedure);

            return result.ToList();
        }
        public async Task<Customer> GetCustomerAsync(int id)
        {
            string commandText = "spGetSingleCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",id }
            };

            var result = await _repository.Get(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
        public async Task<int> CreateAsync(Customer customer)
        {
            string commandText = "spCreateCustomer";

            var parameters = new Dictionary<string, object>()
            {
                {"@name",customer.Name },
                {"@identityNumber",customer.IdentityNumber },
                {"@phoneNumber",customer.PhoneNumber },
                {"@email",customer.Email },
                {"@customerType",customer.Type }
            };

            var result = await _repository.Execute(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
        public async Task<int> UpdateAsync(Customer customer)
        {
            string commandText = "spUpdateCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",customer.Id },
                {"@name",customer.Name },
                {"@identityNumber",customer.IdentityNumber },
                {"@phoneNumber",customer.PhoneNumber },
                {"@email",customer.Email },
                {"@customerType",customer.Type }
            };

            var result = await _repository.Execute(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
        public async Task<int> DeleteAsync(int id)
        {
            string commandText = "spDeleteCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",id }
            };

            var result = await _repository.Execute(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
