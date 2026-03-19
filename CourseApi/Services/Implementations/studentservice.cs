using CourseApi.Data;
using CourseApi.Models;
using CourseApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CourseApi.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllAsync(int pageNumber, int pageSize)
        {
            IQueryable<Student> query = _context.Students;

            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _context.Students
                .Include(s => s.Enrollments)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Student> CreateAsync(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return student;
        }
        public async Task<IEnumerable<Course>> GetStudentCoursesAsync(int studentId)
{
    return await _context.Enrollments
        .Where(e => e.StudentId == studentId)
        .Select(e => e.Course)
        .ToListAsync();
}
    }
}