using BlazorServerCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlazorServerCleanArchitecture.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Stadium> Stadiums => Set<Stadium>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Stadium>().HasData(
            new Stadium
            {
                Name = "Emirates Stadium",
                City = "London",
                Capacity = 60260,
                BuiltYear = 2006,
                PitchLength = 105,
                PitchWidth = 68
            },
            new Stadium
            {
                Name = "Villa Park",
                City = "Birminghan",
                Capacity = 42682,
                BuiltYear = 1897,
                PitchLength = 105,
                PitchWidth = 68
            });
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}