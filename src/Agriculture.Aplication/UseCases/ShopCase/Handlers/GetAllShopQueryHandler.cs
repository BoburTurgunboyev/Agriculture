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
    public class GetAllShopQueryHandler : IRequestHandler<GetAllShopQuery, List<Shop>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllShopQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Shop>> Handle(GetAllShopQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.shops.ToListAsync(cancellationToken);
            return res;
        }
    }
}
