using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.CartCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.CartCase.Handlers
{
    public class UpdateCartCommandHandler : IRequestHandler<UpdateCartCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateCartCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.carts.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            res.Quentity=request.Quentity;
            res.SumTotal = request.SumTotal;

            _appDbContext.carts.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;

            
        }
    }
}
