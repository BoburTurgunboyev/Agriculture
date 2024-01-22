using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.CartCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.CartCase.Handlers
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartComand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateCartCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateCartComand request, CancellationToken cancellationToken)
        {
            var cart = new Cart()
            {
                Quentity = request.Quentity,
                SumTotal = request.SumTotal,
                ProductId = request.ProductId,
            };
            await _appDbContext.carts.AddAsync(cart);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
