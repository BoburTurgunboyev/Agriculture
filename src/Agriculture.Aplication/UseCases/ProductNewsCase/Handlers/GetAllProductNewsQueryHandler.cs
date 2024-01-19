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
    public class GetAllProductNewsQueryHandler : IRequestHandler<GetAllProductNewsQuery, List<ProductNews>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllProductNewsQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ProductNews>> Handle(GetAllProductNewsQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.productsNews.ToListAsync(cancellationToken);
            return res;
        }
    }
}
