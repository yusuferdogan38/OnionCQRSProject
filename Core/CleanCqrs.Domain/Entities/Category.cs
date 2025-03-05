﻿using CleanCqrs.Domain.Common;
using CleanCqrs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Domain.Entityies
{
    public class Category:EntityBase
    {
        public Category()
        {
            
        }

        public Category(int parentId,string name,int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Priorty { get; set; }

        ICollection<ProductCategory> ProductCategories { get; set; }

        public ICollection<Detail> Details { get; set; }


       
    }
}
