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
    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteCartCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.carts.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }
            _appDbContext.carts.Remove(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
