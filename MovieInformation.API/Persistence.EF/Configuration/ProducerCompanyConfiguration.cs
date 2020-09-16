using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieInformation.Domain;

namespace MovieInformation.API.Persistence.EF.Configuration
{
    public class ProducerCompanyConfiguration : BaseEntityConfiguration<ProductionCompany>
    {
        public override void Configure(EntityTypeBuilder<ProductionCompany> builder)
        {
            builder
                .HasOne(x => x.Movie)
                .WithMany()
                .HasForeignKey(x => x.MovieId)
                .IsRequired();

            builder
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}
