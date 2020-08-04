using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
   public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-3VB3SSC\MSSQLSERVERLAST;Database = ShopDb;Integrated Security = true ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(p => new { p.CategoryId, p.ProductId });

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        
        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
} 
