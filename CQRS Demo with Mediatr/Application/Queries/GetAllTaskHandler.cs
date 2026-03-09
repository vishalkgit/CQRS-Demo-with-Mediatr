using CQRS_Demo_with_Mediatr.Domain.Entities;
using CQRS_Demo_with_Mediatr.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo_with_Mediatr.Application.Queries
{
    public class GetAllTaskHandler : IRequestHandler<GetAlllusers, List<User>>
    {

        private readonly ApplicationDBContext _context;

        public GetAllTaskHandler(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<List<User>> Handle(GetAlllusers request, CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync(cancellationToken);
        }
    }
}
