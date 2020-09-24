using BoxOptimizer.Models;
using Microsoft.EntityFrameworkCore;

namespace BoxOptimizer.Data
{
    public class ShipmentContext : DbContext
    {
        public ShipmentContext(DbContextOptions<ShipmentContext> options) : base(options)
        {
        }

        public DbSet<Boxes> Boxes { get; set; }
        public DbSet<ShipmentParts> ShipmentParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Boxes>().HasKey(c => new { c.BOX_ID });
            modelBuilder.Entity<ShipmentParts>().HasKey(c => new { c.BOX_ID, c.PART_NUMBER });

            modelBuilder.Entity<Boxes>().HasMany<ShipmentParts>(g => g.ShipmentParts);
            
            modelBuilder.Entity<Boxes>().ToTable("Boxes");
            modelBuilder.Entity<ShipmentParts>().ToTable("ShipmentParts");
        }
    }
}