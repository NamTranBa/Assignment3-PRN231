using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.IRepository;
using BusinessObject.DTO;
using AutoMapper;

namespace eStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _pro;
        private readonly IMapper _map;
        public ProductsController(IProductRepository pro, IMapper map)
        {
            _pro = pro;
            _map = map;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var list = _pro.GetAllProducts();
            var listmap = _map.Map<IEnumerable<ProductDTO>>(list);
            return Ok(listmap);
        }

        [HttpGet("category")]
        public async Task<ActionResult<IEnumerable<Category>>> Category()
        {
            var list = _pro.GetCategories();
            var promap = _map.Map<IEnumerable<CategoryDTO>>(list);

            return Ok(promap);
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var pro = _pro.GetProducts(id);
            var promap = _map.Map<ProductDTO>(pro);
            return Ok(promap);

        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, AddProductDTO product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }
            
            var pro = _map.Map<Product>(product);
            _pro.UpdateProduct(pro);

            return Ok(pro);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(AddProductDTO product)
        {
            var pro = _map.Map<Product>(product);
            await _pro.AddProduct(pro);
            return Ok(product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
             await _pro.DeleteProduct(id);
            return Ok();
        }

      
    }
}
