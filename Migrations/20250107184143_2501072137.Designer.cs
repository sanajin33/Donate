﻿// <auto-generated />
using System;
using Donate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Donate.Migrations
{
    [DbContext(typeof(DonateDbContext))]
    [Migration("20250107184143_2501072137")]
    partial class _2501072137
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Donate.Data.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "0812dbe6-4c5b-4c05-8271-4cfdefa6df9d",
                            Name = "Donor",
                            NormalizedName = "DONOR"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "4aba19c4-62f5-4bc1-a002-633e78671ced",
                            Name = "Volunteer",
                            NormalizedName = "VOLUNTEER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "040cbb41-c9fd-4cda-8e86-ceb533a31214",
                            Name = "Organization",
                            NormalizedName = "ORGANIZATION"
                        });
                });

            modelBuilder.Entity("Donate.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Active = true,
                            Address = "",
                            ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                            CreatedAt = new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460),
                            Email = "admin@donate.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "",
                            NormalizedEmail = "ADMIN@DONATE.COM",
                            NormalizedUserName = "ADMIN@DONATE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==",
                            PhoneNumber = "987-6543",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                            TwoFactorEnabled = false,
                            UserName = "admin@donate.com"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            Active = true,
                            Address = "",
                            ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                            CreatedAt = new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460),
                            Email = "organization@donate.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "",
                            NormalizedEmail = "ORGANIZATION@DONATE.COM",
                            NormalizedUserName = "ORGANIZATION@DONATE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==",
                            PhoneNumber = "654-3210",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                            TwoFactorEnabled = false,
                            UserName = "organization@donate.com"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            Active = true,
                            Address = "",
                            ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                            CreatedAt = new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460),
                            Email = "donor@donate.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "",
                            NormalizedEmail = "DONOR@DONATE.COM",
                            NormalizedUserName = "DONOR@DONATE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==",
                            PhoneNumber = "954-7426",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                            TwoFactorEnabled = false,
                            UserName = "donor@donate.com"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            Active = true,
                            Address = "",
                            ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6",
                            CreatedAt = new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460),
                            Email = "volunteer@donate.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "",
                            NormalizedEmail = "VOLUNTEER@DONATE.COM",
                            NormalizedUserName = "VOLUNTEER@DONATE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==",
                            PhoneNumber = "6354-8521",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP",
                            TwoFactorEnabled = false,
                            UserName = "volunteer@donate.com"
                        });
                });

            modelBuilder.Entity("Donate.Data.Entities.ViewUser", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<bool?>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.ToView("ViewUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 4
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Donate.Data.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Donate.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Donate.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Donate.Data.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Donate.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Donate.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
