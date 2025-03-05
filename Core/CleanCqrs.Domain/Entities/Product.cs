using CleanCqrs.Domain.Common;
using CleanCqrs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Domain.Entityies
{
    public class Product:EntityBase
    {
        public Product()
        {

        }

        public Product(string name, string description, decimal price, decimal discount, int brandId)
        {
            Name = name;
            Description = description;
            Price = price;
            Discount = discount;
            BrandId = brandId;
        }


        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int BrandId { get; set; }


        ICollection<ProductCategory> ProductCategories { get; set; }
        public Brand Brand { get; set; }




    }
}
