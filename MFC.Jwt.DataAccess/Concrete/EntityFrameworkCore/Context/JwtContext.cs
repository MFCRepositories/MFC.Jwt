using MFC.Jwt.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using MFC.Jwt.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MFC.Jwt.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class JwtContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BEAHAG3\SQLEXPRESS;Database=JwtDb; user id=sa;password=1;");
         
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.ApplyConfiguration(new AppUserMap());
             modelBuilder.ApplyConfiguration(new AppRoleMap());
             modelBuilder.ApplyConfiguration(new AppUserRoleMap());
             modelBuilder.ApplyConfiguration(new ProductMap());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
