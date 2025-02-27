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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
          
          Faker faker = new ("tr");
                
           Brand brand = new Brand() 
           {
               Id = 1,
               Name = faker.Commerce.Department(),
               CreatedDate = DateTime.Now,
               IsDeleted = false,
           };

            Brand brand2 = new Brand()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            Brand brand3 = new Brand()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(brand, brand2, brand3);
        }
    }
}
