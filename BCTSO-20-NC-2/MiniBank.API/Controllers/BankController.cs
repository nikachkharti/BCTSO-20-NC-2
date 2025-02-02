using Microsoft.AspNetCore.Mvc;
using MiniBank.Models;
using MiniBank.Repository;
using MiniBank.Repository.Interfaces;

namespace MiniBank.API.Controllers
{
    [Route("api/bank")]
    [ApiController]
    public class BankController : ControllerBase
    {
        //private readonly CustomerCsvRepository _repo;
        //private readonly SqlClientCustomerRepository _repo;
        private readonly ICustomerRepository _repo;

        public BankController(ICustomerRepository repo)
        {
            //_repo = new CustomerCsvRepository("C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC-2\\BCTSO-20-NC-2\\MiniBank.Repository\\Data\\Customers.csv");
            //_repo = new SqlClientCustomerRepository();
            _repo = repo;

        }


        [HttpGet("customers")]
        public async Task<List<Customer>> GetCustomers()
        {
            var result =  await _repo.GetCustomersAsync();
            return result;
        }
    }
}
