using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    internal class ShippingAddress
    {
        [Key]
        public int ShippingAddressId { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order order { get; set; }

    }
}
