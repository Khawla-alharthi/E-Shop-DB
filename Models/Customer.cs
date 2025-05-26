using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EShop.Models
{
    internal class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<CustomerConatctInfo> Payments { get; set; } = new List<CustomerConatctInfo>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<PaymentInfo> paymentInfos { get; set; } = new List<PaymentInfo>();
    }
}
