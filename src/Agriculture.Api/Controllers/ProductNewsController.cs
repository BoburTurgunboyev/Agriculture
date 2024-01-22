using Agriculture.Aplication.UseCases.ProductNewsCase.Commands;
using Agriculture.Aplication.UseCases.ProductNewsCase.Dtos;
using Agriculture.Aplication.UseCases.ProductNewsCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductNewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductNewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProductNews([FromForm]CreateProductNewsCommand createProductNewsCommand)
        { 
            var result = await _mediator.Send(createProductNewsCommand);
            return Ok("Created");
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateProductNews( UpdateProductNewsCommand updateProductNewsCommand)
        {
            var result = await _mediator.Send(updateProductNewsCommand);
            return Ok("Updated");

        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProductNews(int id)
        {
            var result = await _mediator.Send(new DeleteProductNewsCommand() { Id = id });
            return Ok("Deleted");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllProductNews()
        {
            var result = await _mediator.Send(new GetAllProductNewsQuery());
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdProductNews(int id)
        {
            var result  = await _mediator.Send(new GetByIdProductNewsQuery() { Id = id });  
            return Ok(result);
        }
    }
}
