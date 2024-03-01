using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal? Weight { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public CategoryDTO Category { get; set; }
    }

    public class AddProductDTO
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal? Weight { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
    }
}
