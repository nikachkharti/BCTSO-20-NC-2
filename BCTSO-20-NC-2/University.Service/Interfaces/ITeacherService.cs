using University.Models.Dtos.Teacher;

namespace University.Service.Interfaces
{
    public interface ITeacherService
    {
        Task<List<TeacherForGettingDto>> GetAllTeachers();
        Task<TeacherForGettingDto> GetSingleTeacher(int teacherId);
        Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto);
        Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto);
        Task DeleteTeacher(int id);
        Task SaveTeacher();
    }
}
