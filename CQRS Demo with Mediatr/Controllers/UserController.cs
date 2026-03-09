using CQRS_Demo_with_Mediatr.Application.Commands;
using CQRS_Demo_with_Mediatr.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Demo_with_Mediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserCommand command)
        {

            var res = await _mediator.Send(command);
            return Ok(res);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var res = await _mediator.Send(new GetAlllusers());
            return Ok(res);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }
    }
}
