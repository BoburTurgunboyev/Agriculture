using Agriculture.Aplication.UseCases.ShopCase.commands;
using Agriculture.Aplication.UseCases.ShopCase.Dtos;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShopController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateShop(ShopDto shopdto)
        {
            var shop = new CreateShopCommand()
            {
               
                Adress = shopdto.Adress,
                Phone = shopdto.Phone,
                Email = shopdto.Email,
            };

            var result = await _mediator.Send(shop);
            return Ok(result);  
        }
    }
}
