using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FleetBattles.Models;
using FleetBattles.Models.ChatModels;

namespace FleetBattles.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<UserChannel>().HasKey(x => new { x.ChannelId, x.UserId });
            builder.Entity<FactionChannel>().HasKey(x => new { x.ChannelId, x.FactionId });
        }
        public DbSet<Faction> Factions { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<FactionChannel> FactionChannels { get; set; }
        public DbSet<UserChannel> UserChannel { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}
