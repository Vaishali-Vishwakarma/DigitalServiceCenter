using Microsoft.EntityFrameworkCore;

namespace DigitalServiceCenter.Models
{
    public class CompaneyDbContext : DbContext
    {
        public DbSet<Companey> Companeys { get; set; }
        public DbSet<ApplicationUser> Admin { get; set; }

        public CompaneyDbContext(DbContextOptions<CompaneyDbContext> options) : base(options)
        {
        }
    }
}
