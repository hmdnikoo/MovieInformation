using Microsoft.EntityFrameworkCore;
using MovieInformation.API.Persistence.EF.Configuration;
using MovieInformation.Domain;
using Person = MovieInformation.Domain.Person;

namespace MovieInformation.Persistence.EF
{
    public class MovieInformationDbContext : DbContext
    {
        public MovieInformationDbContext(DbContextOptions<MovieInformationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<ProductionCompany> ProductionCompanies { get; set; }
        public DbSet<Cast> Casts { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("Data Source=MovieInformation.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerConfiguration());
            modelBuilder.ApplyConfiguration(new WriterConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new CastConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
