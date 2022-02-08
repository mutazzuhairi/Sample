using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.Data.Configuration;
using Sample.DataLayer.DataUtilities.Extensions;
using Microsoft.AspNetCore.Identity;

namespace Sample.DataLayer.DataUtilities.DBContext
{
 
    public sealed class MainContext : IdentityDbContext<User, Role, long, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        
        public MainContext (DbContextOptions<MainContext> options) : base(options)
        {

            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddRestrictToRelationshipOnDelete();
            modelBuilder.ApplyConfiguration(new  AbsenceConfiguration());
            modelBuilder.ApplyConfiguration(new  AbsenceApprovalConfiguration());
            modelBuilder.ApplyConfiguration(new  AbsenceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new  BusinessConfiguration());
            modelBuilder.ApplyConfiguration(new  BusinessAbsenceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new  RoleConfiguration());
            modelBuilder.ApplyConfiguration(new  UserConfiguration());
            modelBuilder.ApplyConfiguration(new  UserRoleConfiguration());
            modelBuilder.Ignore<UserToken>();
            modelBuilder.Ignore<UserLogin>();
            modelBuilder.Ignore<UserClaim>();
            modelBuilder.Ignore<RoleClaim>();
            modelBuilder.Entity<User>()
                .Ignore(c => c.LockoutEnabled)
                .Ignore(c => c.TwoFactorEnabled)
                .Ignore(c => c.ConcurrencyStamp)
                .Ignore(c => c.EmailConfirmed)
                .Ignore(c => c.TwoFactorEnabled)
                .Ignore(c => c.LockoutEnd)
                .Ignore(c => c.AccessFailedCount)
                .Ignore(c => c.PhoneNumberConfirmed);

        }

        public DbSet<Absence> Absences { get; set; }
        public DbSet<AbsenceApproval> AbsenceApprovals { get; set; }
        public DbSet<AbsenceType> AbsenceTypes { get; set; }
        public DbSet<Business> Businesss { get; set; }
        public DbSet<BusinessAbsenceType> BusinessAbsenceTypes { get; set; }
        public override DbSet<Role> Roles { get; set; }
        public override DbSet<User> Users { get; set; }
        public override DbSet<UserRole> UserRoles { get; set; }
       
    }
}

