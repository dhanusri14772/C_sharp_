using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.models;
using ProductApi.Services.Interfaces;

namespace ProductApi.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync(int pageNumber, int pageSize , string? search)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(search))
             {
                  query = query.Where(p => EF.Functions.Like(p.Name, $"%{search}%"));
             }
            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<Product?> UpdateAsync(int id, Product product)
{
    var existing = await _context.Products.FindAsync(id);
    if (existing == null)
        return null;

    existing.Name = product.Name;
    existing.Price = product.Price;

    await _context.SaveChangesAsync();
    return existing;
}
    public async Task<bool> DeleteAsync(int id)
{
    var product = await _context.Products.FindAsync(id);
    if (product == null)
        return false;

    _context.Products.Remove(product);
    await _context.SaveChangesAsync();
    return true;
}
    }
}