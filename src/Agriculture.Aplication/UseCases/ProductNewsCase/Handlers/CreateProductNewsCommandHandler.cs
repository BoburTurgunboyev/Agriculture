using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductNewsCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Handlers
{
    public class CreateProductNewsCommandHandler : IRequestHandler<CreateProductNewsCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateProductNewsCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateProductNewsCommand request, CancellationToken cancellationToken)
        {
            var res = new ProductNews() 
            {
                Image = request.Image,
                Vitamin=request.Vitamin,
                VitaminDescription=request.VitaminDescription
            };
            
            _appDbContext.productsNews.Add(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
