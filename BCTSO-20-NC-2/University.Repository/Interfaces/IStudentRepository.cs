using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudent(int studentId);
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int studentId);
    }
}
