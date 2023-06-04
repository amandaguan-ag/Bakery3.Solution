using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
    public class FactoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<MachineEngineer> MachineEngineers { get; set; }

        public FactoryContext(DbContextOptions options) : base(options) { }
    }
}