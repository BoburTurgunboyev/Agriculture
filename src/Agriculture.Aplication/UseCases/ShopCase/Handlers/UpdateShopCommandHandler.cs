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
    public class UpdateShopCommandHandler : IRequestHandler<UpdateShopCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateShopCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateShopCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.shops.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            res.Email=request.Email;
            res.Phone=request.Phone;
            res.Address=request.Address;

            _appDbContext.shops.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
