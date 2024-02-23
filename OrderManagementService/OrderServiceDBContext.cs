using Microsoft.EntityFrameworkCore;
using OrderManagementService.Models;
using System.Collections.Generic;

namespace OrderManagementService
{
    public class OrdersDBContext : DbContext
    {
        public OrdersDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
        //public DbSet<CustomerPaymentInfo> CustomerPaymentInfo { get; set; }

        //public override void OnModelCreating()
        //{

        //}

    }
}
