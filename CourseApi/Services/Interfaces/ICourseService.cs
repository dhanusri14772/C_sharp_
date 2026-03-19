using CourseApi.Models;

namespace CourseApi.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllAsync();
        Task<IEnumerable<Student>> GetCourseStudentsAsync(int courseId);
        Task<Course?> GetByIdAsync(int id);

        Task<Course> CreateAsync(Course course);
    }
}