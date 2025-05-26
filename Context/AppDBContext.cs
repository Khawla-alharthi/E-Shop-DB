using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using EShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EShop.Context
{
    internal class AppDBContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }


        public DbSet<Customer> customers { get; set; }
        public DbSet<Catogry> catogries { get; set; }
        public DbSet<CustomerConatctInfo> customerConatctInfos { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<ShippingAddress> shippingAddresses { get; set; }
        public DbSet<PaymentInfo> paymentInfos { get; set; }
        public DbSet<Review> reviews { get; set; }
    }
}
