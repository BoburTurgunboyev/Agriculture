using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.CartCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.CartCase.Handlers
{
    public class GetAllCartQueryHandler : IRequestHandler<GetAllCartQuery, List<Cart>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllCartQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Cart>> Handle(GetAllCartQuery request, CancellationToken cancellationToken)
        {
            var res= await _appDbContext.carts.ToListAsync(cancellationToken);
            return res;
        }
    }
}
