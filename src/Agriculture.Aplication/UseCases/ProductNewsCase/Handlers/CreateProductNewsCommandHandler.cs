using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.FileSercives.ITTradeSoft.Application.FileServices;
using Agriculture.Aplication.UseCases.ProductNewsCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Handlers
{
    public class CreateProductNewsCommandHandler : IRequestHandler<CreateProductNewsCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IFileService _fileService;

        public CreateProductNewsCommandHandler(IAppDbContext appDbContext, IFileService fileService)
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(CreateProductNewsCommand request, CancellationToken cancellationToken)
        {
            string productnewsimage = await _fileService.UploadImageAsync(request.Image);
            var res = new ProductNews() 
            {
                Image = productnewsimage,
                Vitamin=request.Vitamin,
                VitaminDescription=request.VitaminDescription
            };
            
            _appDbContext.productsNews.Add(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
