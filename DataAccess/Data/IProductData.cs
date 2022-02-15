using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductData
    {
        Task DeleteProduct(int id);
        Task<IEnumerable<Category?>> GetCategories();
        Task<Category?> GetCategoryById(int id);
        Task<Product?> GetProductById(int id);
        Task<IEnumerable<Product?>> GetProducts();
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
    }
}