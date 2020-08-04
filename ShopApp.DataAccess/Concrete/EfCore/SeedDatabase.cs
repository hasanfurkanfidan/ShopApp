using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(products);
                }
                context.SaveChanges();
            }
        }
        private static Category[] categories = {new Category(){Name="Telefon" },
            new Category(){Name="Bilgisayar"}
        };
        private static Product[] products = {new Product() { ProductName="Samsung S5",Price=200,ImageUrl ="1.jpg" },
            new Product() { ProductName="Samsung S6",Price=2500,ImageUrl ="2.jpg" },
            new Product() { ProductName="Samsung S7",Price=3000,ImageUrl ="3.jpg" },

        };

    }
}


