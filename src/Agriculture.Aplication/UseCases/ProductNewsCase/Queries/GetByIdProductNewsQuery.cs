using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Queries
{
    public class GetByIdProductNewsQuery : IRequest<ProductNews>
    {
        public int Id { get; set; }
    }
}
