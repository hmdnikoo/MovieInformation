using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MovieInformation.API.Persistence.EF.Configuration
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {

        protected BaseEntityConfiguration()
        {
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable($"{typeof(T).Name}");
        }
    }
}
