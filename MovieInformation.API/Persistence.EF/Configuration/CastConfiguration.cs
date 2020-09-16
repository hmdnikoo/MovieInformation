﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieInformation.Domain;

namespace MovieInformation.API.Persistence.EF.Configuration
{
    public class CastConfiguration : BaseEntityConfiguration<Cast>
    {
        public override void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder
                .HasOne(x => x.Movie)
                .WithMany()
                .HasForeignKey(x => x.MovieId)
                .IsRequired();

            builder
                .HasOne(x => x.Person)
                .WithMany()
                .HasForeignKey(x => x.PersonId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}
