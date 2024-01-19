using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductServiceCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Handlers
{
    public class UpdateProductServiceCommandHandler : IRequestHandler<UpdateProductServiceCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateProductServiceCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateProductServiceCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.productsService.FirstOrDefaultAsync(x=>x.Id==request.Id);
            if (res!=null)
            {
                return false;
            }

            _appDbContext.productsService.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
