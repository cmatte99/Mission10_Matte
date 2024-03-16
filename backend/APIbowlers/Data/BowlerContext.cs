using Microsoft.EntityFrameworkCore;

namespace APIbowlers.Data
{
    // Represents the database context for bowlers and teams
    public class BowlerContext : DbContext
    {
        // Constructor to initialize the context with options
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }   

        // DbSet for Bowlers table
        public DbSet<Bowlers> Bowlers { get; set; }
        
        // DbSet for Teams table
        public DbSet<Teams> Teams { get; set; }
    }
}
