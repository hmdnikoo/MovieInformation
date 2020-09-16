using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieInformation.Domain;

namespace MovieInformation.API.Persistence.EF.Configuration
{
    public class MovieConfiguration : BaseEntityConfiguration<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasMany(p => p.Casts)
                .WithOne(p => p.Movie)
                .HasForeignKey(p => p.MovieId);

            builder.HasMany(p => p.Producers)
                .WithOne(p => p.Movie)
                .HasForeignKey(p => p.MovieId);

            builder.HasMany(p => p.ProductionCompanies)
                .WithOne(p => p.Movie)
                .HasForeignKey(p => p.MovieId);

            builder.HasMany(p => p.Writers)
                .WithOne(p => p.Movie)
                .HasForeignKey(p => p.MovieId);

            builder.HasMany(p => p.Directors)
                .WithOne(p => p.Movie)
                .HasForeignKey(p => p.MovieId);

            base.Configure(builder);
        }
    }
}
