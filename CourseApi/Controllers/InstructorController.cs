using Microsoft.AspNetCore.Mvc;
using CourseApi.Services.Interfaces;
using CourseApi.DTOs;
using CourseApi.Models;
using AutoMapper;

namespace CourseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _service;
        private readonly IMapper _mapper;

        public InstructorController(IInstructorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var instructors = await _service.GetAllAsync();

            var result = _mapper.Map<IEnumerable<InstructorReadDto>>(instructors);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(InstructorCreateDto dto)
        {
            var instructor = _mapper.Map<Instructor>(dto);

            var created = await _service.CreateAsync(instructor);

            var result = _mapper.Map<InstructorReadDto>(created);

            return Ok(result);
        }
    }
}