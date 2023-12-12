using Microsoft.EntityFrameworkCore;

namespace PINLab5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
    }

}
