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
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, Product>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdProductQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Product> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.products.FirstOrDefaultAsync(x=>x.Id==request.Id);
            return res;
        }
    }
}
