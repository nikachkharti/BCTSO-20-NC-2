using University.Models.Dtos.Course;
using University.Models.Dtos.Teacher;
using University.Models.Entities;
using University.Repository.Interfaces;
using University.Service.Exceptions;
using University.Service.Interfaces;

namespace University.Service.Implementations
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto)
        {
            Teacher obj = new Teacher();
            obj.Name = teacherForCreatingDto.Name;

            await _teacherRepository.Add(obj);
        }

        public async Task DeleteTeacher(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Invalid argument passed");
            }

            await _teacherRepository.Delete(id);
        }

        public async Task<List<TeacherForGettingDto>> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public async Task<TeacherForGettingDto> GetSingleTeacher(int teacherId)
        {
            //1. ვიძახებ რეპოზიტორის
            Teacher repoResult = await _teacherRepository.Get(teacherId);

            if (repoResult == null)
            {
                throw new NotFoundException($"Teacher with {teacherId} not found in database.");
            }

            //2. რეპოზიტორის მიერ დაბრუნებულ შედეგს გარდავაქმნი Dto - ებში.
            TeacherForGettingDto result = new();
            List<CourseForGettingDto> courses = new();

            if (repoResult.Courses.Any())
            {
                foreach (var repoCourses in repoResult.Courses)
                {
                    courses.Add(new CourseForGettingDto() { Id = repoCourses.Id, Title = repoCourses.Title });
                }
            }

            result.Id = repoResult.Id;
            result.Name = repoResult.Name;
            result.Courses = courses;

            return result;
        }

        public async Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto)
        {
            Teacher obj = new();
            obj.Id = teacherForUpdatingDto.Id;
            obj.Name = teacherForUpdatingDto.Name;

            await _teacherRepository.Update(obj);
        }
    }
}
