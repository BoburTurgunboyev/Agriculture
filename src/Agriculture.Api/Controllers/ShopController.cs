using Agriculture.Aplication.UseCases.ShopCase.commands;
using Agriculture.Aplication.UseCases.ShopCase.Commands;
using Agriculture.Aplication.UseCases.ShopCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class ShopController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShopController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateShop(CreateShopCommand createShopCommand)
        {
            var result = await _mediator.Send(createShopCommand);
            return Ok("Created");
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateShop(UpdateShopCommand updateShopCommand)
        {

            var result = await _mediator.Send(updateShopCommand);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteShop(int Id)
        {
            var result = await _mediator.Send(new DeleteShopCommand() { Id = Id });
            return Ok("Deleted");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllShop()
        {
            var result = await _mediator.Send(new GetAllShopQuery());
            return Ok(result);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetById(int Id)
        {
            var result = await _mediator.Send(new GetByIdShopQuery() { Id = Id });
            return Ok(result);
        }



    }
}
