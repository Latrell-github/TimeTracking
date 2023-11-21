using Microsoft.EntityFrameworkCore;
using TimeTracking.Shared.Models;

namespace TimeTracking.Server.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            :base(options)
        { 
        }

        public DbSet<TaskState> Tasks { get; set; }
    }
}
