using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ShopCase.commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ShopCase.Handlers
{
    public class CreateShopCommandHandler : IRequestHandler<CreateShopCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateShopCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateShopCommand request, CancellationToken cancellationToken)
        {
            var shop = new Shop()
            {
                Name = request.Name,
                Adress = request.Adress,
                Phone = request.Phone,
                Email = request.Email,

            };
            await _appDbContext.shops.AddAsync(shop);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result>0;
        }
    }
}
