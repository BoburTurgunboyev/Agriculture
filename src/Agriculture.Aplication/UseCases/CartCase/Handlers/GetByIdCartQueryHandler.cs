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
    public class GetByIdCartQueryHandler : IRequestHandler<GetByIdCartQuery, Cart>
    {
        private readonly IAppDbContext _appDbContext;
        public async Task<Cart> Handle(GetByIdCartQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.carts.FirstOrDefaultAsync(x=>x.Id == request.Id);
            return res;
        }

    }
}
