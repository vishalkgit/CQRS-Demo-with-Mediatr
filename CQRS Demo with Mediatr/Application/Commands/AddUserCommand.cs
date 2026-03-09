using MediatR;

namespace CQRS_Demo_with_Mediatr.Application.Commands
{
    public record AddUserCommand(string UserName,int Age):IRequest<string>;
}
