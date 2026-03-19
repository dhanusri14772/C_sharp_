using CourseApi.Models;

namespace CourseApi.Services.Interfaces
{
    public interface IInstructorService
    {
        Task<IEnumerable<Instructor>> GetAllAsync();

        Task<Instructor> CreateAsync(Instructor instructor);
    }
}