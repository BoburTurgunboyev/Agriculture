using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.FileSercives.ITTradeSoft.Application.FileServices;
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
        private readonly IFileService _fileService;

        public UpdateProductCommandHandler(IAppDbContext appDbContext, IFileService fileService)
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            string productimage = await _fileService.UploadImageAsync(request.Image);
            var res = await _appDbContext.products.FirstOrDefaultAsync(x=>x.Id ==request.Id);
            if (res == null)
            {
                return false;
            }

            res.Name = request.Name;
            res.Image = productimage;
            res.Price = request.Price;
             

            _appDbContext.products.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;

        }
    }
}
