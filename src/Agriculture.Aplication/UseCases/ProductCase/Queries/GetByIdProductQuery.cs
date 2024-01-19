using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductCase.Queries
{
    public class GetByIdProductQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
