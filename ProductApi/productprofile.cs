using AutoMapper;
using ProductApi.models;
using ProductApi.DTOs;

namespace ProductApi.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}