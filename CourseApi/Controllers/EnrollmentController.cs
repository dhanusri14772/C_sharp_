using Microsoft.AspNetCore.Mvc;
using CourseApi.Data;
using CourseApi.DTOs;
using CourseApi.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace CourseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EnrollmentController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(EnrollmentCreateDto dto)
        {
            var enrollment = _mapper.Map<Enrollment>(dto);

            _context.Enrollments.Add(enrollment);

            await _context.SaveChangesAsync();

            var result = _mapper.Map<EnrollmentReadDto>(enrollment);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enrollments = await _context.Enrollments.ToListAsync();

            var result = _mapper.Map<IEnumerable<EnrollmentReadDto>>(enrollments);

            return Ok(result);
        }
    }
}