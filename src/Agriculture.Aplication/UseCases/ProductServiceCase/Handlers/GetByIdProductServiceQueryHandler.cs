using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductServiceCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Handlers
{
    public class GetByIdProductServiceQueryHandler : IRequestHandler<GetByIdProductServiceQuery, ProductService>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdProductServiceQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ProductService> Handle(GetByIdProductServiceQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.productsService.FirstOrDefaultAsync(x=>x.Id == request.Id);
            return result;
        }
    }
}
