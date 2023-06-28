using System.Collections.Concurrent;

namespace EmptyBlazorApp
{
    public interface ICatalog
    {
        Task<List<Product>> GetProductsAsync();
        Task AddProduct(Product product);
        Task ClearProducts();
        Task DeleteProductById(Guid productId);
        Task<Product> GetProductByIdAsync(Guid productId);
        Task UpdateProductById(Guid productId, Product newProduct);
    }
}
