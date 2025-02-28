using CleanCqrs.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Domain.Entityies
{
    public class Detail:EntityBase
    {
        public Detail()
        {
            
        }

        public Detail(int categoryId,string title,string description)
        {
            CategoryId = categoryId;
            Title = title;
            Description = description;

        }


        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set;}
        public Category Category { get; set; }

    }
}
