using System.Reflection.Emit;
using Donate.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Donate.Data;

public class DonateDbContext(DbContextOptions<DonateDbContext> options) : IdentityDbContext<AppUser, AppRole, int>(options)
{
    public DbSet<Project> Projects { get; set; }
    //public DbSet<TaskApplication> Applications { get; set; }
    public DbSet<ProjectTask> Tasks { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<DonationItem> DonationItems { get; set; }
    public DbSet<DonationItemType> DonationItemTypes { get; set; }
    public DbSet<DonationDetail> DonationDetails { get; set; }
    public DbSet<TaskApplication> TaskApplications { get; set; }
    public DbSet<VolunteerProjectTask> VolunteerProjectTasks { get; set; }

    public DbSet<ViewUser> ViewUsers { get; set; }
    public DbSet<ViewProject> ViewProjects { get; set; }
    public DbSet<ViewProjectTask> ViewProjectTasks { get; set; }
    public DbSet<ViewDonationItem> ViewDonationItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Tables
        builder.Entity<AppUser>().ToTable("Users");
        builder.Entity<AppUser>().HasMany(x => x.Roles).WithMany(x => x.Users).UsingEntity<IdentityUserRole<int>>();
        //builder.Entity<AppUser>().HasMany(x => x.VolunteerTasks).WithMany(x => x.VolunteerTasks).UsingEntity<VolunteerProjectTask>();
        builder.Entity<AppUser>().HasMany(x => x.OrganizationProjects).WithOne(x => x.Organization).HasForeignKey(x => x.OrganizationId).OnDelete(DeleteBehavior.Restrict);
        //builder.Entity<AppUser>().HasMany(x => x.Applications).WithOne(x => x.Volunteer).HasForeignKey(x => x.VolunteerId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<AppRole>().ToTable("Roles");
        builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
        builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
        builder.Entity<DonationDetailRecord>().HasNoKey();


        //builder.Entity<Project>().HasMany(x => x.Tasks).WithOne(x => x.Project).HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Donation>().HasMany(x => x.Details).WithOne(x => x.Donation).HasForeignKey(x => x.DonationId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<DonationItem>().HasMany(x => x.Details).WithOne(x => x.DonationItem).HasForeignKey(x => x.DonationItemId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<VolunteerProjectTask>().HasKey(x => new { x.VolunteerId, x.ProjectTaskId });

        builder.Entity<ViewUser>().ToView("ViewUsers").HasKey(x => x.Id);
        builder.Entity<ViewProject>().ToView("ViewProjects").HasKey(x => x.Id);
        builder.Entity<ViewProjectTask>().ToView("ViewProjectTasks").HasKey(x => x.Id);
        builder.Entity<ViewDonationItem>().ToView("ViewDonationItems").HasKey(x => x.Id);

        Seed(builder);
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = 1,
                Name = "Admin",
                Email = "admin@donate.com",
                NormalizedEmail = "ADMIN@DONATE.COM",
                UserName = "admin@donate.com",
                NormalizedUserName = "ADMIN@DONATE.COM",
                PhoneNumber = "987-6543",
                EmailConfirmed = true,
                CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(),
                ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==" //P@ssw0rd
            },
            new AppUser
            {
                Id = 2,
                Name = "Organization",
                Email = "organization@donate.com",
                NormalizedEmail = "ORGANIZATION@DONATE.COM",
                UserName = "organization@donate.com",
                NormalizedUserName = "ORGANIZATION@DONATE.COM",
                PhoneNumber = "654-3210",
                EmailConfirmed = true,
                CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(),
                ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==" //P@ssw0rd
            },
            new AppUser
            {
                Id = 3,
                Name = "Donor",
                Email = "donor@donate.com",
                NormalizedEmail = "DONOR@DONATE.COM",
                UserName = "donor@donate.com",
                NormalizedUserName = "DONOR@DONATE.COM",
                PhoneNumber = "954-7426",
                EmailConfirmed = true,
                CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(),
                ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==" //P@ssw0rd
            },
            new AppUser
            {
                Id = 4,
                Name = "Volunteer",
                Email = "volunteer@donate.com",
                NormalizedEmail = "VOLUNTEER@DONATE.COM",
                UserName = "volunteer@donate.com",
                NormalizedUserName = "VOLUNTEER@DONATE.COM",
                PhoneNumber = "6354-8521",
                EmailConfirmed = true,
                CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(),
                ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==" //P@ssw0rd
            }
        );

        builder.Entity<AppRole>().HasData(
            new AppRole { Id = 1, Name = "Admin", NormalizedName = "Admin".ToUpper(), ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", },
            new AppRole { Id = 2, Name = "Donor", NormalizedName = "Donor".ToUpper(), ConcurrencyStamp = "0812dbe6-4c5b-4c05-8271-4cfdefa6df9d", },
            new AppRole { Id = 3, Name = "Volunteer", NormalizedName = "Volunteer".ToUpper(), ConcurrencyStamp = "4aba19c4-62f5-4bc1-a002-633e78671ced", },
            new AppRole { Id = 4, Name = "Organization", NormalizedName = "Organization".ToUpper(), ConcurrencyStamp = "040cbb41-c9fd-4cda-8e86-ceb533a31214", }
        );

        builder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int> { UserId = 1, RoleId = 1 },
            new IdentityUserRole<int> { UserId = 2, RoleId = 2 },
            new IdentityUserRole<int> { UserId = 3, RoleId = 3 },
            new IdentityUserRole<int> { UserId = 4, RoleId = 4 }
        );
    }
}
