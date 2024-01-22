using Agriculture.Aplication.UseCases.ProductCase.Commands;
using Agriculture.Aplication.UseCases.ProductCase.Dtos;
using Agriculture.Aplication.UseCases.ProductCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateProduct(CreateProductCommand createProductCommand)
        {
            var result = await _mediator.Send(createProductCommand);
            return Ok("Created");
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateProduct(UpdateProductCommand updateProductCommand) 
        {
            var result = await _mediator.Send(updateProductCommand);
            return Ok("Updated");
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProduct(int id)
        {
            var result  = await _mediator.Send(new DeleteProductCommand() { Id = id });
            return Ok("Deleted");
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllProduct()
        {
            var result = await _mediator.Send(new GetAllProductQuery());
            return Ok(result);  
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdProduct(int id) 
        {
            var result = await _mediator.Send(new GetByIdProductQuery() { Id = id });   
            return Ok(result);
        }
    }
}
