using MiniBank.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MiniBank.Repository
{
    public class SqlClientCustomerRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCTSO20N;Trusted_Connection=true;TrustServerCertificate=true";

        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer> result = new();

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new("spGetAllCustomers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        Customer customer = new();
                        customer.Id = reader.GetInt32(0);
                        customer.Name = reader.GetString(1);
                        customer.IdentityNumber = reader.GetString(2);
                        customer.PhoneNumber = reader.GetString(3);
                        customer.Email = reader.GetString(4);
                        customer.Type = Enum.Parse<CustomerType>(reader.GetByte(5).ToString());

                        result.Add(customer);
                    }
                }
            }

            return result;
        }
        public async Task<Customer> GetCustomer(int id)
        {
            Customer result = new();

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new("spGetSingleCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("customerId", id);

                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        result.Id = reader.GetInt32(0);
                        result.Name = reader.GetString(1);
                        result.IdentityNumber = reader.GetString(2);
                        result.PhoneNumber = reader.GetString(3);
                        result.Email = reader.GetString(4);
                        result.Type = Enum.Parse<CustomerType>(reader.GetByte(5).ToString());
                    }
                }
            }

            return result;
        }
        public async Task Create(Customer customer)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new("spAddNewCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("name", customer.Name);
                    command.Parameters.AddWithValue("identityNumber", customer.IdentityNumber);
                    command.Parameters.AddWithValue("phoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("email", customer.Email);
                    command.Parameters.AddWithValue("customerType", customer.Type);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Update(Customer customer)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new("spUpdateCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("customerId", customer.Id);
                    command.Parameters.AddWithValue("name", customer.Name);
                    command.Parameters.AddWithValue("identityNumber", customer.IdentityNumber);
                    command.Parameters.AddWithValue("phoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("email", customer.Email);
                    command.Parameters.AddWithValue("customerType", customer.Type);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
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
