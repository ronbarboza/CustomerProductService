using CustomerProductService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerProductService
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPaymentInfo> CustomerPaymentInfo { get; set; }
    }
}
