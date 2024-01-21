using Agriculture.Aplication.UseCases.CartCase.Commands;
using Agriculture.Aplication.UseCases.CartCase.Dtos;
using Agriculture.Aplication.UseCases.CartCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCart(CreateCartComand createCartComand)
        {
            var result  =  await _mediator.Send(createCartComand);
            return Ok("Created");
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateCart(UpdateCartCommand updateCartCommand) 
        {
            var result = await _mediator.Send(updateCartCommand);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteCart(int id) 
        {
            var cart = await _mediator.Send(new DeleteCartCommand() { Id = id });
            return Ok("Deleted");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllCart()
        {
            var result = await _mediator.Send(new GetAllCartQuery());
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdCart(int id) 
        {
            var result = await _mediator.Send(new GetByIdCartQuery() { Id = id });  
            return Ok(result);
        }
    }
}
