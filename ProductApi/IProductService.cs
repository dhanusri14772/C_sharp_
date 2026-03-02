using ProductApi.models;
namespace ProductApi.Services.Interfaces{

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync(int pageNumber, int pageSize , string? search);
    Task<Product?> GetByIdAsync(int id);
    Task<Product?> UpdateAsync(int id, Product product);
    Task<Product> CreateAsync(Product product);
    Task<bool> DeleteAsync(int id);
}
}