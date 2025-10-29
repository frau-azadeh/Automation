using Automation.DataModelLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Automation.DataModelLayer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers, ApplicationRoles, string>
    {
        // فیلد استاتیک حذف شد

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUsers>(entity =>
            {
                entity.ToTable(name: "Users_Tb1");
                entity.Property(e => e.Id).HasColumnName("UserId");
            });

            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable(name: "Roles_Tb1");
            });
        }

        // در صورت نیاز DbSetها را اضافه کن
        // public DbSet<MyEntity> MyEntities { get; set; }
    }
}
