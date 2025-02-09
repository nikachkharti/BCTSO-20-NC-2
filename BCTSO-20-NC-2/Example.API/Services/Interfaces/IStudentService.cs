using Example.API.Models;

namespace Example.API.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetSingleStudent(int id);
        void AddStudent(Student model);
        void UpdateStudent(Student model);
        void DelteStudent(int id);
    }
}
