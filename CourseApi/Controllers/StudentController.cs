using Microsoft.AspNetCore.Mvc;
using CourseApi.Services.Interfaces;
using AutoMapper;
using CourseApi.DTOs;
using CourseApi.Models;

namespace CourseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        private readonly IMapper _mapper;

        public StudentController(IStudentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber = 1, int pageSize = 10)
        {
            var students = await _service.GetAllAsync(pageNumber, pageSize);

            var result = _mapper.Map<IEnumerable<StudentReadDto>>(students);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateDto dto)
        {
            var student = _mapper.Map<Student>(dto);

            var created = await _service.CreateAsync(student);

            var result = _mapper.Map<StudentReadDto>(created);

            return Ok(result);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _service.GetByIdAsync(id);

            if (student == null)
                return NotFound();

            var result = _mapper.Map<StudentReadDto>(student);

            return Ok(result);
        }
        [HttpGet("{id}/courses")]
public async Task<IActionResult> GetStudentCourses(int id)
{
    var courses = await _service.GetStudentCoursesAsync(id);

    var result = _mapper.Map<IEnumerable<CourseReadDto>>(courses);

    return Ok(result);
}
    
    
    
    
    
    
    
    
    
    
    }
}