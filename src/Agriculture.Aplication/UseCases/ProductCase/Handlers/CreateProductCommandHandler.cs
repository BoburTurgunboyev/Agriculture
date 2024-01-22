using Agriculture.Aplication.Absreaction;
using Agriculture.Aplication.FileSercives.ITTradeSoft.Application.FileServices;
using Agriculture.Aplication.UseCases.ProductCase.Commands;
using Agriculture.Domain.Entities;
using MediatR;

namespace Agriculture.Aplication.UseCases.ProductCase.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IFileService _fileService;

        public CreateProductCommandHandler(IAppDbContext appDbContext, IFileService fileService )
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            string productimage = await _fileService.UploadImageAsync(request.Image);
            var product = new Product()
            {
                Name = request.Name,
                Image = productimage,
                Price = request.Price,
                
            };

            _appDbContext.products.Add(product);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
