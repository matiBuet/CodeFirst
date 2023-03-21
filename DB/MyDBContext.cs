using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable(nameof(Brand));
            modelBuilder.Entity<Beer>().ToTable(nameof(Beer));
        }
    }
}