using Example.API.Models;
using Example.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{

    [ApiController]
    [Route("Students")]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = _studentService.GetAllStudents();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetSingleStudent([FromRoute] int id)
        {
            var result = _studentService.GetAllStudents(); //1

            foreach (var item in result)
            {
                _studentService.GetSingleStudent(item.Id);
            }

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent([FromRoute] int id)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        public IActionResult AddStudent([FromBody] Student model)
        {
            throw new NotImplementedException();
        }


        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student model)
        {
            throw new NotImplementedException();
        }

    }
}
