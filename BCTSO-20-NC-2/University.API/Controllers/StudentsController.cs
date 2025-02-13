using Microsoft.AspNetCore.Mvc;
using University.Models.Entities;
using University.Repository.Data;

namespace University.API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student model)
        {
            _context.Students.Add(model);
            _context.SaveChanges();

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent([FromRoute] int id)
        {
            var studentToDelete = _context.Students.FirstOrDefault(x => x.Id == id);
            _context.Students.Remove(studentToDelete);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student model)
        {
            var studentToUpdate = _context.Students.FirstOrDefault(x => x.Id == model.Id);

            studentToUpdate.Name = model.Name;
            studentToUpdate.PersonalNumber = model.PersonalNumber;
            studentToUpdate.Email = model.Email;
            studentToUpdate.BirthDate = model.BirthDate;

            _context.SaveChanges();
            return Ok();
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            var result = _context.Students.ToList();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetStudent([FromRoute] int id)
        {
            var result = _context.Students.FirstOrDefault(x => x.Id == id);
            return Ok(result);
        }
    }
}
