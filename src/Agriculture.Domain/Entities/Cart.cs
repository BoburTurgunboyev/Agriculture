using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int Howmany { get; set; }
        public decimal SumTotal { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
