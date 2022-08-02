using Microsoft.EntityFrameworkCore;

namespace DigitalServiceCenter.Models
{
    public class CompaneyDbContext : DbContext
    {
        public DbSet<Companey> Companeys { get; set; }
        public DbSet<Admin> Admin { get; set; }

        public CompaneyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
