using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.FileSercives.ITTradeSoft.Application.FileServices;
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
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IFileService _fileService;

        public UpdateUserCommandHandler(IAppDbContext appDbContext, IFileService fileService)
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            string userimage = await _fileService.UploadImageAsync(request.Image);
            var res = await _appDbContext.users.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (res == null)
            {
                return false;
            }

            res.FullName = request.FullName;
            res.Image = userimage;
            res.Job= request.Job;

            _appDbContext.users.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
