using BusinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDAO;
        private readonly CategoryDAO _categoryDAO;
        public ProductRepository(ProductDAO productDAO, CategoryDAO categoryDAO)
        {
            _productDAO = productDAO;
            _categoryDAO = categoryDAO;

        }
        public IEnumerable<Category> GetCategories() => _categoryDAO.GetAll();
        public async Task AddProduct(Product Product) => await _productDAO.AddNewProduct(Product);
        public Task DeleteProduct(int Product) => _productDAO.Delete(Product);
        public IEnumerable<Product> GetAllProducts() => _productDAO.GetAllProducts();
        public Product GetProducts(int id) => _productDAO.GetProductById(id);
        public void UpdateProduct(Product Product) => _productDAO.UpdateProduct(Product);

    }
}
