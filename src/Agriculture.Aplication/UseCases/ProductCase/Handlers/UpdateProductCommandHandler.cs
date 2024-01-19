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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateProductCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.products.FirstOrDefaultAsync(x=>x.Id ==request.Id);
            if (res == null)
            {
                return false;
            }

            res.Name = request.Name;    
            res.Image = request.Image;
            res.Price = request.Price;

            _appDbContext.products.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;

        }
    }
}
