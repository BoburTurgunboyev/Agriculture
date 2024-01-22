﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculture.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public ICollection<ProductService> ProductServices {  get; set; } 

        


    }
}
