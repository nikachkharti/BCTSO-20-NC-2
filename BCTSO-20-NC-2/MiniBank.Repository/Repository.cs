using Microsoft.Data.SqlClient;
using MiniBank.Repository.Interfaces;
using System.Data;
using System.Reflection;

namespace MiniBank.Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly string _connectionString;
        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> Execute(string query, CommandType commandType, Dictionary<string, object> parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters is not null || parameters.Count != 0)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                        }
                    }

                    return await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task<T> Get(string query, CommandType commandType, Dictionary<string, object> parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters is not null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            if (await reader.ReadAsync()) // ვკითხულობ მხოლოდ 1 ჩანაწერს.
                            {
                                T result = new T();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    //ამოვიღე ბაზიდან სვეტის დასახელება.
                                    string columnName = reader.GetName(i);
                                    //ამოვიღე ბაზიდან სვეტის მინიშვნელონბა.
                                    object columnValue = reader.GetValue(i);

                                    //Reflection შევქმენი ახალი ფროფერთი რომელის სახელიც არის columnName ტიპი არის public 
                                    PropertyInfo prop = typeof(T).GetProperty(columnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

                                    //თუ ბაზიდან ამოღებული ColumnValue არ არის null prop - ს მივანიჭოთ ის
                                    if (prop != null && columnValue != DBNull.Value)
                                    {
                                        prop.SetValue(result, Convert.ChangeType(columnValue, prop.PropertyType));
                                    }
                                }

                                return result;
                            }
                        }
                    }
                }

                return default;
            }
        }
        public async Task<IEnumerable<T>> GetAll(string query, CommandType commandType, Dictionary<string, object> parameters = null)
        {
            List<T> results = new();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters is not null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync()) // ვკითხულობ მხოლოდ 1 ჩანაწერს.
                            {
                                T result = new();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    //ამოვიღე ბაზიდან სვეტის დასახელება.
                                    string columnName = reader.GetName(i);
                                    //ამოვიღე ბაზიდან სვეტის მინიშვნელონბა.
                                    object columnValue = reader.GetValue(i);

                                    //Reflection შევქმენი ახალი ფროფერთი რომელის სახელიც არის columnName ტიპი არის public 
                                    PropertyInfo prop = typeof(T).GetProperty(columnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

                                    //თუ ბაზიდან ამოღებული ColumnValue არ არის null prop - ს მივანიჭოთ ის
                                    if (prop != null && columnValue != DBNull.Value)
                                    {
                                        prop.SetValue(result, Convert.ChangeType(columnValue, prop.PropertyType));
                                    }
                                }

                                results.Add(result);
                            }
                        }
                    }
                }

                return results;
            }
        }
    }
}
