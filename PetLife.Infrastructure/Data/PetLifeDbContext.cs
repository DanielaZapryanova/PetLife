using Microsoft.EntityFrameworkCore;
using PetLife.Infrastructure.Data.Models;

namespace PetLife.Infrastructure.Data
{
    public class PetLifeDbContext : DbContext
    {
        public PetLifeDbContext()
        {
        }

        public PetLifeDbContext(DbContextOptions<PetLifeDbContext> options) : base(options)
        {
        }

        public DbSet<Test> Pets { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
    }
}
