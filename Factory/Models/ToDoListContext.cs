using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
    public class FactoryContext : DbContext
    {
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Category> Categories { get; set; }

        public FactoryContext(DbContextOptions options) : base(options) { }
    }
}