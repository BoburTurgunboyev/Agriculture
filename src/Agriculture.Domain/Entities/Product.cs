﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductService ProductService { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public Farm Farm { get; set; }  

    }
}