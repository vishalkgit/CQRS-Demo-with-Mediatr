using CQRS_Demo_with_Mediatr.Domain.Entities;
using MediatR;

namespace CQRS_Demo_with_Mediatr.Application.Queries
{
    public record GetAllTaskQuery : IRequest<List<TaskItem>>;

}
