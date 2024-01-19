using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductCase.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateProductCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Name = request.Name,
                Image = request.Image,
                Price = request.Price
            };

            _appDbContext.products.Add(product);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
