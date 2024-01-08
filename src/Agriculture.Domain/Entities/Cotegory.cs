using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    public class Cotegory
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Image { get; set; }

        public ICollection<Product> Products { get; set; }
       
    }
}
