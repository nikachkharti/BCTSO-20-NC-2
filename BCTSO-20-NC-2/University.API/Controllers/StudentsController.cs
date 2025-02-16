using Microsoft.AspNetCore.Mvc;
using University.Models.Entities;
using University.Repository.Interfaces;

namespace University.API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student model)
        {
            await _studentRepository.Add(model);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] int id)
        {
            await _studentRepository.Delete(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent([FromBody] Student model)
        {
            await _studentRepository.Update(model);
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var result = await _studentRepository.GetAll();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent([FromRoute] int id)
        {
            var result = await _studentRepository.Get(id);
            return Ok(result);
        }
    }
}
