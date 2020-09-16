using Microsoft.EntityFrameworkCore;
using MovieInformation.Domain;

namespace MovieInformation.Persistence.EF
{
    public class MovieInformationDbContext : DbContext
    {
        public MovieInformationDbContext(DbContextOptions<MovieInformationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }


    }
}
