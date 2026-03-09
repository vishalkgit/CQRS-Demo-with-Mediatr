using CQRS_Demo_with_Mediatr.Domain.Entities;
using CQRS_Demo_with_Mediatr.Infrastructure;
using MediatR;

namespace CQRS_Demo_with_Mediatr.Application.Commands
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
    {

        private readonly ApplicationDBContext _context;

        public CreateTaskCommandHandler(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskItem
            {
                Title = request.Title
                
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync(cancellationToken);

            return task.Id;
        }
    }
}
