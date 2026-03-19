using CourseApi.Models;

namespace CourseApi.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync(int pageNumber, int pageSize);
        Task<IEnumerable<Course>> GetStudentCoursesAsync(int studentId);
        Task<Student> GetByIdAsync(int id);

        Task<Student> CreateAsync(Student student);
    }
} 