using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddStudent(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudent(int studentId)
        {
            var studentToDelete = await _context.Students.FirstOrDefaultAsync(x => x.Id == studentId);
            _context.Students.Remove(studentToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudent(int studentId)
        {
            var result = await _context.Students.FirstOrDefaultAsync(x => x.Id == studentId);
            return result;
        }

        public async Task UpdateStudent(Student student)
        {
            var studentToUpdate = await _context.Students.FirstOrDefaultAsync(x => x.Id == student.Id);

            studentToUpdate.Name = student.Name;
            studentToUpdate.PersonalNumber = student.PersonalNumber;
            studentToUpdate.Email = student.Email;
            studentToUpdate.BirthDate = student.BirthDate;

            await _context.SaveChangesAsync();
        }
    }
}
