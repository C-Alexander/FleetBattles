using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FleetBattles.Models.ChatModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FleetBattles.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DefaultValue(1)]
        public int FactionId { get; set; }
        public Faction Faction { get; set; }

        [Required]
        [DefaultValue(1)]
        public int RaceId { get; set; }
        public Race Race { get; set; }
        [Required]
        public string DisplayName { get; set; }
        public List<UserChannel> Channels { get; set; }
    }
}
