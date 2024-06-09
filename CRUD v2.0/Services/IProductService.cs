using CRUD_v2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD_v2.Services
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<(bool, string)> DeleteProduct(Product product);
        Task<Product> UpdateProduct(Product product);
    }
}
