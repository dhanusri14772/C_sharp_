using Microsoft.AspNetCore.Mvc;
using CourseApi.Services.Interfaces;
using CourseApi.Models;
using CourseApi.DTOs;
using AutoMapper;
namespace CourseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;
        private readonly IMapper _mapper;
        public CourseController(ICourseService service ,  IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _service.GetAllAsync();

            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _service.GetByIdAsync(id);

            if (course == null)
                return NotFound();

            var result = _mapper.Map<CourseReadDto>(course);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto dto)
{
    var course = _mapper.Map<Course>(dto);
    var created = await _service.CreateAsync(course);
    var result = _mapper.Map<CourseReadDto>(created);

    return Ok(result);

        }
    
    [HttpGet("{id}/students")]
public async Task<IActionResult> GetCourseStudents(int id)
{
    var students = await _service.GetCourseStudentsAsync(id);
    var result = _mapper.Map<IEnumerable<StudentReadDto>>(students);
    return Ok(result);
}
    }
}

