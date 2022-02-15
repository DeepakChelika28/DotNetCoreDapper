using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class ProductData : IProductData
    {
        private readonly ISqlDataAccess _dataAccess;
        public ProductData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<IEnumerable<Product?>> GetProducts() => _dataAccess.GetData<Product, dynamic>("dbo.spGetProducts", new { });

        public Task<IEnumerable<Category?>> GetCategories() => _dataAccess.GetData<Category, dynamic>("dbo.spGetCategories", new { });

        public async Task<Product?> GetProductById(int id)
        {
            var results = await _dataAccess.GetData<Product, dynamic>("dbo.spGetProductById", new { ProductId = id });

            return results.FirstOrDefault();
        }

        public async Task<Category?> GetCategoryById(int id)
        {
            var results = await _dataAccess.GetData<Category, dynamic>("dbo.spGetProductById", new { CategoryId = id });

            return results.FirstOrDefault();
        }

        public Task InsertProduct(Product product)
        {
            return _dataAccess.SaveData<dynamic>("dbo.spInsertProduct", new { product.Name, product.Description, product.UnitPrice, product.CategoryId });
        }

        public Task UpdateProduct(Product product)
        {
            return _dataAccess.SaveData<Product>("dbo.spUpdateProduct", product);
        }

        public Task DeleteProduct(int id)
        {
            return _dataAccess.SaveData<dynamic>("dbo.spDeleteProduct", new { ProductId = id });
        }
    }
}
