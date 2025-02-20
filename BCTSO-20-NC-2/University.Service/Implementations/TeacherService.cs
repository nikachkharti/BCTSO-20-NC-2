using AutoMapper;
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
        private readonly IMapper _mapper;

        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto)
        {
            var obj = _mapper.Map<Teacher>(teacherForCreatingDto);
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
            //1. ვიძახებ რეპოზიტორის
            List<Teacher> teachers = await _teacherRepository.GetAll();

            if (!teachers.Any())
            {
                throw new NotFoundException($"Teachers not found in database.");
            }

            //2. რეპოზიტორის მიერ დაბრუნებულ შედეგს გარდავაქმნი Dto - ებში.
            var reuslt = _mapper.Map<List<TeacherForGettingDto>>(teachers);
            return reuslt;
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
            var result = _mapper.Map<TeacherForGettingDto>(repoResult);
            return result;
        }

        public async Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto)
        {
            var obj = _mapper.Map<Teacher>(teacherForUpdatingDto);
            await _teacherRepository.Update(obj);
        }
    }
}
