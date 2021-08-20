using System.Collections.Generic;
using Orders.Model;
using Microsoft.EntityFrameworkCore;

namespace Orders.DAL
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OrderDB;Trusted_Connection=True;");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var products = new List<Product>
            {
                new Product {ProductId = 1, Name = "Toy Car", Description = "Red", Quantity = 5},
                new Product {ProductId = 2, Name = "Action man", Description = "Muscles", Quantity = 2}
            };

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
