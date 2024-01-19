using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductNewsCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Handlers
{
    public class GetByIdProductNewsQueryHandler : IRequestHandler<GetByIdProductNewsQuery, ProductNews>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdProductNewsQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ProductNews> Handle(GetByIdProductNewsQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.productsNews.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
