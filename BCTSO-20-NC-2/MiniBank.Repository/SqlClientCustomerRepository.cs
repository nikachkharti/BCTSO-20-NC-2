using MiniBank.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using MiniBank.Repository.Interfaces;

namespace MiniBank.Repository
{
    public class SqlClientCustomerRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCTSO20N;Trusted_Connection=true;TrustServerCertificate=true";
        private readonly IRepository<Customer> _repository;
        public SqlClientCustomerRepository()
        {
            _repository = new Repository<Customer>(_connectionString);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var result = await _repository.GetAll("spGetAllCustomers", CommandType.StoredProcedure, parameters: null);
            return result.ToList();
        }


        public async Task<Customer> GetCustomer(int id)
        {
            Dictionary<string, object> parameters = new()
            {
                {"@customerId",id }
            };

            var result = await _repository.Get("spGetSingleCustomer", CommandType.StoredProcedure, parameters: parameters);
            return result;
        }


        public async Task<int> Create(Customer customer)
        {
            string commandText = "spAddNewCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@name",customer.Name },
                {"@identityNumber",customer.IdentityNumber },
                {"@phoneNumber",customer.PhoneNumber },
                {"@email",customer.Email },
                {"@customerType",customer.CustomerType }
            };

            var result = await _repository.Execute(commandText, CommandType.StoredProcedure, parameters);
            return result;
        }



        public async Task<int> Update(Customer customer)
        {
            string commandText = "spUpdateCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",customer.Id },
                {"@name",customer.Name },
                {"@identityNumber",customer.IdentityNumber },
                {"@phoneNumber",customer.PhoneNumber },
                {"@email",customer.Email },
                {"@customerType",customer.CustomerType }
            };

            var result = await _repository.Execute(commandText, CommandType.StoredProcedure, parameters);
            return result;
        }


        public async Task Delete(int id)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new("spDeleteCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("customerId", id);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
