using DENEMEMEMEMEMEMEMWEMEME.Entities;
using Microsoft.EntityFrameworkCore;

namespace DENEMEMEMEMEMEMEMWEMEME.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GRDREHV\SQLEXPRESS; Database=CodeFirstDb; Trusted_Connection=True; TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
