using RedisApp.API.Models;

namespace RedisApp.API.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAsync();

        Task<Product> GetByIdAsync(int id);

        Task<Product> CreateAsync(Product product);
    }
}