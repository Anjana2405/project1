using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project1.Models;

namespace project1.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
        public string status { get; set; }
    }

    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<project1.Models.Category> Category { get; set; }
        public DbSet<project1.Models.Cart> Cart { get; set; }
        public DbSet<project1.Models.Discount> Discount { get; set; }
        public DbSet<project1.Models.Food> Food { get; set; }
        public DbSet<project1.Models.Inventory> Inventory { get; set; }
        public DbSet<project1.Models.ProducsSold> ProducsSold { get; set; }
        public DbSet<project1.Models.Sale> Sale { get; set; }

    }
}