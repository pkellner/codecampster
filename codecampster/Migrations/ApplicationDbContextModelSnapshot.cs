﻿// <auto-generated />
using Codecamp2018.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Codecamp2018.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Codecamp2018.Models.Announcement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiresOn");

                    b.Property<string>("Message");

                    b.Property<DateTime>("PublishOn");

                    b.Property<int>("Rank");

                    b.HasKey("ID");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Codecamp2018.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("AvatarID");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Location");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool?>("RSVP");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Twitter");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<bool?>("Volunteer");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Codecamp2018.Models.AttendeeSession", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("SessionID");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("SessionID");

                    b.ToTable("AttendeeSessions");
                });

            modelBuilder.Entity("Codecamp2018.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("AttendeeRegistrationOpen");

                    b.Property<string>("CompleteAddress");

                    b.Property<DateTime>("EventEnd");

                    b.Property<DateTime>("EventStart");

                    b.Property<bool>("IsCurrent");

                    b.Property<string>("Name");

                    b.Property<string>("SocialMediaHashtag");

                    b.Property<bool?>("SpeakerRegistrationOpen");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Codecamp2018.Models.Session", b =>
                {
                    b.Property<int>("SessionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CoSpeakerID");

                    b.Property<string>("CoSpeakers");

                    b.Property<string>("Description");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("KeyWords");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("SpeakerID");

                    b.Property<bool?>("Special");

                    b.Property<int?>("TimeslotID");

                    b.Property<int?>("TrackID");

                    b.HasKey("SessionID");

                    b.HasIndex("SpeakerID");

                    b.HasIndex("TimeslotID");

                    b.HasIndex("TrackID");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Codecamp2018.Models.Speaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("AuthorDetails");

                    b.Property<string>("AvatarURL");

                    b.Property<string>("Bio");

                    b.Property<string>("Blog");

                    b.Property<string>("Company");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsMvp");

                    b.Property<string>("LinkedIn");

                    b.Property<string>("MVPDetails");

                    b.Property<string>("NoteToOrganizers");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool?>("Special");

                    b.Property<string>("Title");

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("Codecamp2018.Models.Sponsor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarURL");

                    b.Property<string>("Bio");

                    b.Property<string>("CompanyName");

                    b.Property<string>("SponsorLevel");

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.HasKey("ID");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("Codecamp2018.Models.Timeslot", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("Rank");

                    b.Property<bool?>("Special");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("ID");

                    b.ToTable("Timeslots");
                });

            modelBuilder.Entity("Codecamp2018.Models.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("RoomNumber");

                    b.HasKey("ID");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Codecamp2018.Models.AttendeeSession", b =>
                {
                    b.HasOne("Codecamp2018.Models.ApplicationUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Codecamp2018.Models.Session", "RelatedSession")
                        .WithMany()
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Codecamp2018.Models.Session", b =>
                {
                    b.HasOne("Codecamp2018.Models.Speaker", "Speaker")
                        .WithMany("Sessions")
                        .HasForeignKey("SpeakerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Codecamp2018.Models.Timeslot", "Timeslot")
                        .WithMany("Sessions")
                        .HasForeignKey("TimeslotID");

                    b.HasOne("Codecamp2018.Models.Track", "Track")
                        .WithMany("Sessions")
                        .HasForeignKey("TrackID");
                });

            modelBuilder.Entity("Codecamp2018.Models.Speaker", b =>
                {
                    b.HasOne("Codecamp2018.Models.ApplicationUser", "AppUser")
                        .WithOne("Speaker")
                        .HasForeignKey("Codecamp2018.Models.Speaker", "ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Codecamp2018.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Codecamp2018.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Codecamp2018.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Codecamp2018.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
