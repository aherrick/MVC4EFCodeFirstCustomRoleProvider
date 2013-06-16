using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC4CustomRoleProvider.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(x => x.Users)
                .WithMany(x => x.Roles)
            .Map(x =>
            {
                x.ToTable("UserRoles"); 
                x.MapLeftKey("UserId");
                x.MapRightKey("RoleId");
            });
        }
    }
}