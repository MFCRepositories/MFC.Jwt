using System;
using System.Collections.Generic;
using System.Text;
using MFC.Jwt.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFC.Jwt.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(I=>I.Id);

            builder.Property(I=>I.Id).UseIdentityColumn();
            builder.Property(I=>I.Name).HasMaxLength(100).IsRequired();
        }
    }
}
