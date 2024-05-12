using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopsic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopsic.DataAccess.Configurations
{
    internal class NamedEntityConfiguration<T> : EntityConfiguration<T>
        where T : NamedEntity
    {

        protected override void ConfigureEntity(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x=>x.Name)
                   .IsUnique();
        }
    }
}
