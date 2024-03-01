using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetAllProducts();
        Product GetProducts(int id);
        Task AddProduct(Product Product);
        void UpdateProduct(Product Product);
        Task DeleteProduct(int Product);
    }
}
