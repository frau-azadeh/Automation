using Automation.DataModelLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.DataModelLayer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers,ApplicationRoles,string>
    {
        private static DbContextOptions option;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(option)
        {

        }
        //change name and field Table
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
    }
}
