using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.UseCases.UserCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.UserCase.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateUserCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                FullName=request.FullName,
                Image=request.Image,
                Job=request.Job,
            };

            _appDbContext.users.Add(user);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result>0;
        }
    }
}
