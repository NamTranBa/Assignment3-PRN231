using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
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
        public decimal? Freight { get; set; }

        [ForeignKey("MemberId")]
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
