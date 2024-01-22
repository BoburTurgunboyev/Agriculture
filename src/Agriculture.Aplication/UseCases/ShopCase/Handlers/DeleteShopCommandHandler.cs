using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ShopCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ShopCase.Handlers
{
    public class DeleteShopCommandHandler : IRequestHandler<DeleteShopCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteShopCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteShopCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.shops.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }
            _appDbContext.shops.Remove(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
