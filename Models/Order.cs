using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    internal class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public ICollection<ShippingAddress> shippingAddresses { get; set; } = new List<ShippingAddress>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
