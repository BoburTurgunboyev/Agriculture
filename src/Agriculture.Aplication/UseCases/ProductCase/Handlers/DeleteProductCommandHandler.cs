using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductCase.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteProductCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.products.FirstOrDefaultAsync(x=>x.Id == request.Id); 
            if (res == null)
            {
                return false;
            }
            _appDbContext.products.Remove(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
