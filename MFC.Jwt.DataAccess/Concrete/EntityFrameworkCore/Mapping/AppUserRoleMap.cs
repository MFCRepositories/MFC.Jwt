using System;
using System.Collections.Generic;
using System.Text;
using MFC.Jwt.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFC.Jwt.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AppUserRoleMap:IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(I => I.Id);   //Dapper için Maplemede sıkıntı cıkarmasın diye boyle yaptık
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasIndex(I => new {I.AppUserId, I.AppRoleId}).IsUnique();//2 tane primary Key olusturduk da..

        }
    }
}
