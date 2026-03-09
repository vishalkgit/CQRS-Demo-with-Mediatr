using CQRS_Demo_with_Mediatr.Domain.Entities;
using MediatR;

namespace CQRS_Demo_with_Mediatr.Application.Commands
{
    public record UpdateUserCommand(int Id,string username,int age):IRequest<string>;
}
