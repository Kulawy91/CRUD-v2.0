using Microsoft.EntityFrameworkCore;
using CRUD_v2.Data;
using CRUD_v2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CRUD_v2.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<(bool, string)> DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return (true, "Product deleted");
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
