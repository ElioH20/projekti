using Microsoft.EntityFrameworkCore;
using Projekti.Data.Models;

namespace Projekti.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Rezervim> Rezervime { get; set; }
    }
}
