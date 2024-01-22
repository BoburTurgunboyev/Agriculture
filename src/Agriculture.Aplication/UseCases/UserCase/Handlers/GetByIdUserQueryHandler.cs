using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.UserCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.UserCase.Handlers
{
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, User>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdUserQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            var result  = await _appDbContext.users.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
