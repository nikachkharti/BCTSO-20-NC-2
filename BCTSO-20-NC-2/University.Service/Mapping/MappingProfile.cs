using AutoMapper;
using University.Models.Dtos.Course;
using University.Models.Dtos.Teacher;
using University.Models.Entities;

namespace University.Service.Mapping
{
    public class MappingProfile : Profile
    {
        //ForPath მეთოდი გამოყენეთ nested ტიპების გადასაყვანად.
        public MappingProfile()
        {
            CreateMap<TeacherForCreatingDto, Teacher>()
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name));

            CreateMap<TeacherForUpdatingDto, Teacher>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name));


            CreateMap<Course, CourseForGettingDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, options => options.MapFrom(src => src.Title));


            CreateMap<Teacher, TeacherForGettingDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.Courses, options => options.MapFrom(src => src.Courses));

        }
    }
}
