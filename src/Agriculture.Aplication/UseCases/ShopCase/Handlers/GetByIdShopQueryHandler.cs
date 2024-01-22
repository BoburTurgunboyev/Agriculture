using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ShopCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ShopCase.Handlers
{
    public class GetByIdShopQueryHandler : IRequestHandler<GetByIdShopQuery, Shop>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdShopQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        async Task<Shop> IRequestHandler<GetByIdShopQuery, Shop>.Handle(GetByIdShopQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.shops.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
        }
    }
}
