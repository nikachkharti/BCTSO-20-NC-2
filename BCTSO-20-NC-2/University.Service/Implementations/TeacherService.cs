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
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper, IImageService imageService)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
            _imageService = imageService;
        }

        public async Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto)
        {
            if (teacherForCreatingDto is null)
            {
                throw new ArgumentNullException($"Invalid argument passed");
            }

            var allTeachers = await _teacherRepository.GetAllAsync(pageNumber: 1, pageSize: 10);

            if (allTeachers.Any(x => x.Name.ToLower().Trim() == teacherForCreatingDto.Name.ToLower().Trim()))
            {
                throw new AmbigousNameException();
            }

            teacherForCreatingDto.ProfilePictureUrl = await _imageService.UploadImage(teacherForCreatingDto.ProfilePicture);

            var obj = _mapper.Map<Teacher>(teacherForCreatingDto);
            await _teacherRepository.AddAsync(obj);
        }

        public async Task DeleteTeacher(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Invalid argument passed {id}");
            }

            var teacherToDelete = await _teacherRepository.GetAsync(x => x.Id == id);

            if (teacherToDelete is null)
            {
                throw new NotFoundException($"Teacher with id {id} not found");
            }

            if (!string.IsNullOrWhiteSpace(teacherToDelete.ProfilePictureUrl))
            {
                _imageService.DeleteImage(teacherToDelete.ProfilePictureUrl);
            }

            _teacherRepository.Remove(teacherToDelete);
        }

        public async Task<List<TeacherForGettingDto>> GetAllTeachers(int pageNumber, int pageSize)
        {
            //1. ვიძახებ რეპოზიტორის
            List<Teacher> teachers = await _teacherRepository.GetAllAsync(pageNumber, pageSize, includeProperties: "Courses");

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
            if (teacherId <= 0)
            {
                throw new ArgumentException($"Argument can't be a negative number");
            }

            //1. ვიძახებ რეპოზიტორის
            var repoResult = await _teacherRepository.GetAsync(x => x.Id == teacherId, includeProperties: "Courses");

            if (repoResult is null)
            {
                throw new NotFoundException($"Teacher with {teacherId} not found in database.");
            }

            //2. რეპოზიტორის მიერ დაბრუნებულ შედეგს გარდავაქმნი Dto - ებში.
            var result = _mapper.Map<TeacherForGettingDto>(repoResult);
            return result;

        }

        public async Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto)
        {
            if (teacherForUpdatingDto is null)
            {
                throw new ArgumentException($"Invalid argument passed {teacherForUpdatingDto}");
            }

            var teacherToUpdate = await _teacherRepository.GetAsync(x => x.Id == teacherForUpdatingDto.Id);

            if (teacherToUpdate is null)
            {
                throw new NotFoundException($"Teacher with id {teacherForUpdatingDto.Id} not found");
            }

            var obj = _mapper.Map<Teacher>(teacherForUpdatingDto);
            await _teacherRepository.Update(obj);
        }

        public async Task SaveTeacher() => await _teacherRepository.Save();
    }
}
