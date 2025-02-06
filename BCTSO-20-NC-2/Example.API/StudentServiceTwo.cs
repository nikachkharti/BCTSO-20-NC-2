using Example.API.Models;

namespace Example.API
{
    public class StudentServiceTwo : IStudentService
    {
        private static List<Student> _students = new()
        {
            new Student() { Id = 1, Name = "Lana Stin", SubjectId = 1},
            new Student() { Id = 2, Name = "Luka Biwadze", SubjectId = 2},
            new Student() { Id = 3, Name = "Lizi Kenchoshivli", SubjectId = 2}
        };

        public void AddStudent(Student model)
        {
            throw new NotImplementedException();
        }

        public void DelteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetSingleStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student model)
        {
            throw new NotImplementedException();
        }
    }
}
