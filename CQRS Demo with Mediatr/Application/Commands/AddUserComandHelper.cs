using CQRS_Demo_with_Mediatr.Domain.Entities;
using CQRS_Demo_with_Mediatr.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CQRS_Demo_with_Mediatr.Application.Commands
{
    public class AddUserComandHelper:IRequestHandler<AddUserCommand, string>
    {
        public readonly ApplicationDBContext _context;

        public AddUserComandHelper(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var task = new User
            {
                UName = request.UserName,
                Age = request.Age
            };
            if(task.Age<=0)
            {
                task.Age=18;
            }

            _context.Users.Add(task);
         
            await _context.SaveChangesAsync(cancellationToken);
            return $"User {request.UserName} added successfully with age {task.Age}.";
        }
    }
}
