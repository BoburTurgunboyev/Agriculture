using Agriculture.Aplication.UseCases.ProductServiceCase.Commands;
using Agriculture.Aplication.UseCases.ProductServiceCase.Dtos;
using Agriculture.Aplication.UseCases.ProductServiceCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class ProductServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]

        public async ValueTask<IActionResult> CreateproductService(CreateProductServiceCommand createProductServiceCommand)
        {
            var result = await _mediator.Send(createProductServiceCommand);
            return Ok("Created");

        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateProductService( UpdateProductServiceCommand updateProductServiceCommand)
        { 
            var result = await _mediator.Send(updateProductServiceCommand);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProductService(int id)
        {
            var productservice = await _mediator.Send(new  DeleteProductServiceCommand() { Id = id });
            return Ok("Deleted");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllProductService()
        {
            var result = await _mediator.Send(new GetAllProductServiceQuery());
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdProductService(int id)
        {
            var result =  await _mediator.Send(new GetByIdProductServiceQuery() { Id = id });
            return Ok(result);
        }
    }
}
