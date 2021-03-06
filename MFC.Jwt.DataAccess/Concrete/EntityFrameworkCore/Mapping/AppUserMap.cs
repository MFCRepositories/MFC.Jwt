using MFC.Jwt.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFC.Jwt.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AppUserMap:IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(I=>I.Id);
            builder.Property(I=>I.Id).UseIdentityColumn();

            builder.Property(I=>I.UserName).HasMaxLength(100).IsRequired();
            builder.HasIndex(I => I.UserName).IsUnique();//aynı data girilemez

            builder.Property(I => I.Password).HasMaxLength(100).IsRequired();
            builder.Property(I => I.FullName).HasMaxLength(150);

            builder
                .HasMany(I => I.AppUserRoles)
                .WithOne(I => I.AppUser)
                .HasForeignKey(I=>I.AppUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
