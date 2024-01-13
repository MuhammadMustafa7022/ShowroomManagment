using Microsoft.EntityFrameworkCore;

namespace ShowroomManagmentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Department> Departments { get; set; }
    }
}
