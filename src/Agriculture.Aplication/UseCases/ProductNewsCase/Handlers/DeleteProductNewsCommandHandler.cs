﻿using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.ProductNewsCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Handlers
{

    public class DeleteProductNewsCommandHandler : IRequestHandler<DeleteProductNewsCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteProductNewsCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteProductNewsCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.productsNews.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbContext.productsNews.Remove(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
