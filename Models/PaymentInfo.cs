using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    internal class PaymentInfo
    {
        [Key]
        public int PaymentInfoId { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public int CVV {get; set; }
        [Required]
        public DateTime ExpDate { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


    }
}
