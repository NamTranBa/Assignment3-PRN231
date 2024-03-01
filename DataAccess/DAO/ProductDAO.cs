using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        private readonly eStore2Context _context;
        public ProductDAO(eStore2Context context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var listpro =  _context.Products.Include(c=>c.Category).ToList();
            return listpro;
        }

        public Product GetProductById(int id)
        {
            var product =  _context.Products.Include(c=> c.Category).SingleOrDefault(i => i.ProductId == id);
            return product;
        }

        public async Task AddNewProduct(Product product)
        {
           await _context.Products.AddAsync(product);
           await _context.SaveChangesAsync();
        }
        public async Task UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var p = await _context.Products.SingleOrDefaultAsync(i => i.ProductId == id);
            _context.Products.Remove(p);
            await _context.SaveChangesAsync();
        }
    }
}
