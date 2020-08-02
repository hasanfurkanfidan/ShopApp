using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class Product:IEntity
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }


    }
}
