using Microsoft.AspNetCore.Mvc;
using MiniBank.Services.Interfaces;

namespace MiniBank.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var result = await _customerService.GetCustomers();
            return Ok(result);
        }
    }
}
