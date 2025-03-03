﻿using CleanCqrs.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Domain.Entityies
{
    public class Product:EntityBase
    {


        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int BrandId { get; set; }
     

        public Brand Brand { get; set; }

        ICollection<Category> Categories { get; set; }


    }
}
