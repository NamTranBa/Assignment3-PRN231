using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }
        public ApplicationUserDTO user { get; set; }
    }

    public class OrderComposeDTO
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string MemberId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime? RequiredDate { get; set; }
        [Required]
        public DateTime? ShippedDate { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Discount { get; set; }
    }
}
