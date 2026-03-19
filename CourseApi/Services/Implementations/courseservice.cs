using CourseApi.Data;
using CourseApi.Models;
using CourseApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CourseApi.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course?> GetByIdAsync(int id)
        {
            return await _context.Courses
                .Include(c => c.Instructor)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Course> CreateAsync(Course course)
        {
            _context.Courses.Add(course);

            await _context.SaveChangesAsync();

            return course;
        }
    public async Task<IEnumerable<Student>> GetCourseStudentsAsync(int courseId)
{
    return await _context.Enrollments
        .Where(e => e.CourseId == courseId)
        .Select(e => e.Student)
        .ToListAsync();
}
    }
}