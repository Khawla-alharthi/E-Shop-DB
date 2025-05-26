using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    internal class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal indItemPrice { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order order { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }
    }
}
