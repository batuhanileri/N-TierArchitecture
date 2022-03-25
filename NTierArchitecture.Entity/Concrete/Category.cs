﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entity.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public List<Blog> Blog { get; set; } // Bir kategoride birden fazla blog olabilir 1-n 
                                             // 1 = Category
                                             // n = Blog
    }
}
