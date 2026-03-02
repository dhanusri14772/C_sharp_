using FluentValidation;
using ProductApi.DTOs;
namespace ProductApi.Validators{

public class ProductValidator : AbstractValidator<ProductCreateDto>
{
    public ProductValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Price).GreaterThan(0);
    }
}}