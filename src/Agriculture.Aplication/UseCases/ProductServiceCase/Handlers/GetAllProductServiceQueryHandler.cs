using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductServiceCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Handlers
{
    public class GetAllProductServiceQueryHandler : IRequestHandler<GetAllProductServiceQuery, List<ProductService>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllProductServiceQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ProductService>> Handle(GetAllProductServiceQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.productsService.ToListAsync(cancellationToken);
            return result;
        }
    }
}
