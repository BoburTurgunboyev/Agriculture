using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.UserCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.UserCase.Handlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteUserCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.users.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbContext.users.Remove(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
