using CQRS_Demo_with_Mediatr.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo_with_Mediatr.Infrastructure
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        public DbSet<TaskItem> Tasks { get; set; }

        public DbSet<User> Users { get; set; }  
    }
}
