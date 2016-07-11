using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FleetBattles.Data;

namespace FleetBattles.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160709140700_isw3")]
    partial class isw3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FleetBattles.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("FactionId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("RaceId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("RaceId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FleetBattles.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ChannelId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("FleetBattles.Models.ChatMessage", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChannelId");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("MessageId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserId1");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("FleetBattles.Models.ChatModels.FactionChannel", b =>
                {
                    b.Property<int>("ChannelId");

                    b.Property<int>("FactionId");

                    b.HasKey("ChannelId", "FactionId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("FactionId");

                    b.ToTable("FactionChannels");
                });

            modelBuilder.Entity("FleetBattles.Models.ChatModels.UserChannel", b =>
                {
                    b.Property<int>("ChannelId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("ChannelId", "UserId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserChannel");
                });

            modelBuilder.Entity("FleetBattles.Models.Faction", b =>
                {
                    b.Property<int>("FactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adjective")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 15);

                    b.Property<string>("IconURL")
                        .IsRequired();

                    b.Property<bool>("IsPublic");

                    b.Property<string>("LogoURL")
                        .IsRequired();

                    b.Property<string>("LongName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 35);

                    b.Property<int>("RaceId");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 15);

                    b.HasKey("FactionId");

                    b.HasIndex("RaceId");

                    b.ToTable("Factions");
                });

            modelBuilder.Entity("FleetBattles.Models.Race", b =>
                {
                    b.Property<int>("RaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adjective")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 15);

                    b.Property<string>("AvatarURL")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 15);

                    b.HasKey("RaceId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FleetBattles.Models.ApplicationUser", b =>
                {
                    b.HasOne("FleetBattles.Models.Faction", "Faction")
                        .WithMany()
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FleetBattles.Models.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FleetBattles.Models.ChatMessage", b =>
                {
                    b.HasOne("FleetBattles.Models.Channel", "Channel")
                        .WithMany("Messages")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FleetBattles.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("FleetBattles.Models.ChatModels.FactionChannel", b =>
                {
                    b.HasOne("FleetBattles.Models.Channel", "Channel")
                        .WithMany("Factions")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FleetBattles.Models.Faction", "User")
                        .WithMany("Channels")
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FleetBattles.Models.ChatModels.UserChannel", b =>
                {
                    b.HasOne("FleetBattles.Models.Channel", "Channel")
                        .WithMany("Users")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FleetBattles.Models.ApplicationUser", "User")
                        .WithMany("Channels")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("FleetBattles.Models.Faction", b =>
                {
                    b.HasOne("FleetBattles.Models.Race", "DefaultRace")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FleetBattles.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FleetBattles.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FleetBattles.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
