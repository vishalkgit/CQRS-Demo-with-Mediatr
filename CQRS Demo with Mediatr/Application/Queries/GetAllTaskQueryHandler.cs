using CQRS_Demo_with_Mediatr.Domain.Entities;
using CQRS_Demo_with_Mediatr.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo_with_Mediatr.Application.Queries
{
    public class GetAllTaskQueryHandler : IRequestHandler<GetAllTaskQuery, List<TaskItem>>
    {
        private readonly ApplicationDBContext _context;

        public GetAllTaskQueryHandler(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<TaskItem>> Handle(GetAllTaskQuery request, CancellationToken cancellationToken)
        {
           return await _context.Tasks.ToListAsync(cancellationToken);
        }
    }
}
