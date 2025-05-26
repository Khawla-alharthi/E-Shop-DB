using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Catogry catogry { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
