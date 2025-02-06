using Example.API.Models;

namespace Example.API
{
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new()
        {
            new Student() { Id = 1, Name = "Mariam Iniashvili", SubjectId = 1},
            new Student() { Id = 2, Name = "Giorgi Menteshashvili", SubjectId = 2},
            new Student() { Id = 3, Name = "Saba Beridze", SubjectId = 2}
        };

        public void AddStudent(Student model)
        {
            _students.Add(model);
        }

        public void DelteStudent(int id)
        {
            var result = _students.FirstOrDefault(x => x.Id == id);
            _students.Remove(result);
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetSingleStudent(int id)
        {
            return _students.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateStudent(Student model)
        {
            var studentToUpdate = _students.FirstOrDefault(x => x.Id == model.Id);
            studentToUpdate.Name = model.Name;
        }
    }
}
