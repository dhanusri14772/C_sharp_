using AutoMapper;
using CourseApi.Models;
using CourseApi.DTOs;

namespace CourseApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentReadDto>();

            CreateMap<StudentCreateDto, Student>();
        
            CreateMap<Course, CourseReadDto>();

            CreateMap<CourseCreateDto, Course>();
            CreateMap<InstructorCreateDto, Instructor>();
            CreateMap<Instructor, InstructorReadDto>();
            CreateMap<EnrollmentCreateDto, Enrollment>();
            CreateMap<Enrollment, EnrollmentReadDto>();
        
        
        }
    }
}