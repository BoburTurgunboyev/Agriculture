using Agriculture.Aplication.UseCases.UserCase.Commands;
using Agriculture.Aplication.UseCases.UserCase.Dtos;
using Agriculture.Aplication.UseCases.UserCase.Queries;
using Agriculture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateUser( CreateUserCommand createUserCommand)
        {
            var result = await _mediator.Send(createUserCommand);
            return Ok("Created");
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateUser(UpdateUserCommand updateUserCommand)
        {
            var result = await _mediator.Send(updateUserCommand);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteUser(int id)
        {
            var result = await _mediator.Send(new DeleteUserCommand() { Id = id });
            return Ok("Deleted");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllUser() 
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetById(int id)
        {
            var result =  await _mediator.Send(new GetByIdUserQuery() { Id=id});
            return Ok(result); 
        }
    }
}
