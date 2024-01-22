using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.FileSercives.ITTradeSoft.Application.FileServices;
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
    public class UpdateProductNewsCommandHandler : IRequestHandler<UpdateProductNewsCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IFileService _fileService;

        public UpdateProductNewsCommandHandler(IAppDbContext appDbContext, IFileService fileService)
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(UpdateProductNewsCommand request, CancellationToken cancellationToken)
        {
            string productnewsimage = await _fileService.UploadImageAsync(request.Image);
           var res =await _appDbContext.productsNews.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            res.Image=productnewsimage;
            res.Vitamin=request.Vitamin;
            res.VitaminDescription=request.VitaminDescription; 
            
            _appDbContext.productsNews.Remove(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }


    }
}
