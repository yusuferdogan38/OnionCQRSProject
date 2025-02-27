using Bogus;
using CleanCqrs.Domain.Entityies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");
            Product product1 = new()
            {
                Id = 1,
                BrandId = 1,
                Name= faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Random.Decimal(1, 1000),
                Discount = faker.Random.Decimal(1, 100),
                CreatedDate = DateTime.Now,
                IsDeleted = false,  
            };



            Product product2 = new()
            {
                Id = 2,
                BrandId = 2,
                Name = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Random.Decimal(1, 1000),
                Discount = faker.Random.Decimal(1, 100),
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            };


            Product product3 = new()
            {
                Id = 3,
                BrandId = 3,
                Name = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Random.Decimal(1, 1000),
                Discount = faker.Random.Decimal(1, 100),
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            };

            builder.HasData(product1, product2, product3);
        }

     
    }
}
