using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductServiceCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Handlers
{
    public class CreateProductServiceCommandHandler : IRequestHandler<CreateProductServiceCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateProductServiceCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateProductServiceCommand request, CancellationToken cancellationToken)
        {
            var res = new ProductService()
            {
                DairyProducts = request.DairyProducts,
                StoreServices = request.StoreServices,
                DeliveryServices = request.DeliveryServices,
                AgriculturalServices = request.AgriculturalServices,
                OrganicProducts = request.OrganicProducts,
                FreshVegetables = request.FreshVegetables,
                ProductId = request.ProductId,
                
            };
            _appDbContext.productsService.Add(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
