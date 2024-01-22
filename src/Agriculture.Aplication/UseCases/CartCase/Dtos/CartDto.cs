using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.CartCase.Dtos
{
    public class CartDto
    {
        public int Quentity { get; set; }
        public decimal SumTotal { get; set; }
        public int ProductId { get; set; }
    }
}
