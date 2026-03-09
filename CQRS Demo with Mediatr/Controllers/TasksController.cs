using CQRS_Demo_with_Mediatr.Application.Commands;
using CQRS_Demo_with_Mediatr.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Demo_with_Mediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        private readonly IMediator _mediator;


        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var task = await _mediator.Send(new GetAllTaskQuery());
            return Ok(task);
        }
    }
}
