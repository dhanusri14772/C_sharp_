using Microsoft.AspNetCore.Mvc;
using CourseApi.Data;
using Microsoft.EntityFrameworkCore;
namespace CourseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public LinqController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("students-with-a")]
        public async Task<IActionResult> GetStudentsWithA()
        {
            var result = await _context.Students.Where(s => s.Name.Contains("a")).ToListAsync();
            return Ok(result);
        }
    }
}

