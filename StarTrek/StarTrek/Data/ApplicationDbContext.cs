using Microsoft.EntityFrameworkCore;
using StarTrek.Models;

namespace StarTrek.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Nave> Naves { get; set; }
    }
}
