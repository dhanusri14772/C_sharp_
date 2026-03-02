using Microsoft.AspNetCore.Mvc;
using ProductApi.DTOs;
using ProductApi.models;
using ProductApi.Services.Interfaces;
using AutoMapper;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
   {
        private readonly IProductService _service; 
        private readonly IMapper _mapper;

     public ProductController(IProductService service, IMapper mapper)
    {
    _service = service;
    _mapper = mapper;
    }
        [HttpGet]
public async Task<IActionResult> GetAll(int pageNumber = 1, int pageSize = 10 , string? search = null)
{
    var products = await _service.GetAllAsync(pageNumber, pageSize, search);

    var result = _mapper.Map<IEnumerable<ProductReadDto>>(products);

    return Ok(result);
}

        [HttpPost]
public async Task<IActionResult> Create(ProductCreateDto dto)
{
    var product = _mapper.Map<Product>(dto);

    var created = await _service.CreateAsync(product);

    var result = _mapper.Map<ProductReadDto>(created);

    return Ok(result);
}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
         var product = await _service.GetByIdAsync(id);

         if (product == null)
              return NotFound();

               return Ok(product);
        }
    }
}