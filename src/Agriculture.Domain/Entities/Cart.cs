using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    internal class Cart
    {
        public int Id { get; set; }
        public int Quentity { get; set; }
        public decimal SumTotal { get; set; }
        public int ProductId {  get; set; }
        public Product Product { get; set; }
       

    }
}
