using CourseApi.Data;
using CourseApi.Models;
using CourseApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CourseApi.Services.Implementations
{
    public class InstructorService : IInstructorService
    {
        private readonly ApplicationDbContext _context;

        public InstructorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Instructor>> GetAllAsync()
        {
            return await _context.Instructors.ToListAsync();
        }

        public async Task<Instructor> CreateAsync(Instructor instructor)
        {
            _context.Instructors.Add(instructor);

            await _context.SaveChangesAsync();

            return instructor;
        }
    }
}