using MediatR;

namespace CQRS_Demo_with_Mediatr.Application.Commands
{
   
        public record CreateTaskCommand(string Title):IRequest<int>;
    
}
