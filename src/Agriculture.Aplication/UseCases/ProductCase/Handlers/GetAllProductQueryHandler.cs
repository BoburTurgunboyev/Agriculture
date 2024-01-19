using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductCase.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<Product>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllProductQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.products.ToListAsync(cancellationToken);
            return result;
        }
    }
}
