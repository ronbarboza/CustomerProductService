using Microsoft.EntityFrameworkCore;
using ProductService.Models;
using System.Collections.Generic;

namespace ProductService
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
