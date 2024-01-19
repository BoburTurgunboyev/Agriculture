using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Queries
{
    public class GetByIdProductServiceQuery:IRequest<ProductService>
    {
        public int Id { get; set; }
    }
}
