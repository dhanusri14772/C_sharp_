using CourseApi.Data;
using CourseApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApi.Practice
{
    public class LinqExamples
    {
        private readonly ApplicationDbContext _context;

        public LinqExamples(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetStudentsWithA()
        {
            return await _context.Students
                .Where(s => s.Name.Contains("a"))
                .ToListAsync();
        }

        public async Task<List<Student>> GetStudentsAboveAge(int age)
        {
            return await _context.Students
                .Where(s => s.Age > age)
                .ToListAsync();
        }

        public async Task<List<string>> GetStudentNames()
        {
            return await _context.Students
                .Select(s => s.Name)
                .ToListAsync();
        }

        public async Task<List<object>> GetStudentBasicInfo()
        {
            return await _context.Students
                .Select(s => new 
                { 
                    s.Name, 
                    s.Email 
                })
                .ToListAsync<object>();
        }

        public async Task<Student?> GetStudentById(int id)
        {
            return await _context.Students
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Student?> GetFirstStudent()
        {
            return await _context.Students
                .FirstOrDefaultAsync();
        }

        public async Task<bool> StudentExists(string email)
        {
            return await _context.Students
                .AnyAsync(s => s.Email == email);
        }

        public async Task<int> GetStudentCount()
        {
            return await _context.Students.CountAsync();
        }

        public async Task<List<Student>> GetStudentsOrderedByName()
        {
            return await _context.Students
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<List<Student>> GetStudentsOrderedDesc()
        {
            return await _context.Students
                .OrderByDescending(s => s.Name)
                .ToListAsync();
        }

        public async Task<List<Student>> GetPagedStudents(int page, int size)
        {
            return await _context.Students
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();
        }

        public async Task<List<Course>> GetCoursesByStudent(int studentId)
        {
            return await _context.Enrollments
                .Where(e => e.StudentId == studentId)
                .Select(e => e.Course)
                .ToListAsync();
        }

        public async Task<List<Student>> GetStudentsByCourse(int courseId)
        {
            return await _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .Select(e => e.Student)
                .ToListAsync();
        }
        public async Task<List<object>> GroupStudentsByAge()
        {
            return await _context.Students
                .GroupBy(s => s.Age)
                .Select(g => new
                {
                    Age = g.Key,
                    Count = g.Count()
                })
                .ToListAsync<object>();
        }

        public async Task<List<Student>> GetFilteredStudents()
        {
            return await _context.Students
                .Where(s => s.Age > 20 && s.Name.StartsWith("D"))
                .ToListAsync();
        }

        public async Task<List<Course>> GetCoursesWithInstructor()
        {
            return await _context.Courses
                .Include(c => c.Instructor)
                .ToListAsync();
        }

        public async Task<List<object>> GetStudentCourseDetails()
        {
            return await _context.Enrollments
                .Select(e => new
                {
                    StudentName = e.Student.Name,
                    CourseTitle = e.Course.Title
                })
                .ToListAsync<object>();
        }
    }
}