using Microsoft.AspNetCore.Mvc;

namespace MiniBank.API.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    [ApiController]
    [Route("Students")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new()
        {
            new Student() {Id = 1, Name = "Mariam Iniashvili"},
            new Student() {Id = 2, Name = "Saba Beridze"},
            new Student() {Id = 3, Name = "Giorgi Menteshashvili"},
        };


        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return _students;
        }


        [HttpGet("{id}")]
        public Student GetSingleStudent([FromRoute] int id)
        {
            return _students.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public List<Student> AddStudent([FromBody] Student student)
        {
            var newId = _students.Max(x => x.Id) + 1;
            student.Id = newId;

            _students.Add(student);
            return _students;
        }


        [HttpDelete("{id}")]
        public List<Student> DeleteStudent([FromRoute] int id)
        {
            var studentToRemove = _students.FirstOrDefault(x => x.Id == id);
            _students.Remove(studentToRemove);

            return _students;
        }

        [HttpPut]
        public List<Student> UpdateStudent([FromBody] Student model)
        {
            var studentToUpdate = _students.FirstOrDefault(x => x.Id == model.Id);
            studentToUpdate.Name = model.Name;

            return _students;
        }


        //[HttpGet("student")]
        //public Student GetSingleStudent([FromQuery] int id)
        //{
        //    return _students.FirstOrDefault(x => x.Id == id);
        //}


        //[HttpGet("student")]
        //public Student GetSingleStudent([FromBody] Student model)
        //{
        //    return _students.FirstOrDefault(x => x.Id == model.Id);
        //}

        //[HttpGet("student")]
        //public Student GetSingleStudent([FromForm] Student model)
        //{
        //    return _students.FirstOrDefault(x => x.Id == model.Id);
        //}

        //[HttpGet("student")]
        //public Student GetSingleStudent([FromHeader] Student model)
        //{
        //    return _students.FirstOrDefault(x => x.Id == model.Id);
        //}
    }
}
