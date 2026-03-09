using CQRS_Demo_with_Mediatr.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CQRS_Demo_with_Mediatr.Application.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, string>
    {
        private readonly ApplicationDBContext _context;

        public UpdateUserCommandHandler(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var res = _context.Users.Find(request.Id);
            if(res is null)
            {
                return await Task.FromResult($"User with id {request.Id} not found.");
            }
            res.UName = request.username;
            res.Age = request.age;
            _context.Users.Update(res);
            await _context.SaveChangesAsync(cancellationToken);
            return $"User with id {request.Id} updated successfully.";

        }
    }
}
