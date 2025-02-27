using Example.API.Models.Entity;
using Example.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controller
{
    [Route("ToDo")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository _todorepository;


        public ToDoController(IToDoRepository todorepository)
        {
            _todorepository = todorepository;
        }

        [HttpPost("addTask")]
        public async Task<IActionResult>Add([FromBody] Todo model)
        {
             await _todorepository.Add(model);
            return Ok();
        }


    }
}
