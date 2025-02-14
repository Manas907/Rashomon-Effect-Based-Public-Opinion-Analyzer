using Microsoft.EntityFrameworkCore;
using RashomonEffectApp.Models;

namespace RashomonEffectApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Opinion> Opinions { get; set; }
    }
}
