using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public DbSet<Author> Authors { get; set; }

        public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>()
                .HasData(
                    new Location { LocationId = 1, City = "Seattle", Country = "USA", Review = "Rainy", AuthorId = 1 },
                    new Location { LocationId = 2, City = "Pheonix", Country = "USA", Review = "Hot", AuthorId = 2 }
                );

            builder.Entity<Author>()
                .HasData(
                    new Author { AuthorId = 1, AuthorName = "Trevor Mackin" },
                    new Author { AuthorId = 2, AuthorName = "Uriel Gonzalez" }
                );    
        }

    }
}