using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopsic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopsic.DataAccess.Configurations
{
    internal class ProductConfiguration : EntityConfiguration<Product>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Price)
                .HasPrecision(10, 2);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200);


            builder.HasOne(x => x.Category)
                   .WithMany(c=>c.Products)
                   .HasForeignKey(x=>x.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
