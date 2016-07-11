using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FleetBattles.Models.ChatModels;
using Microsoft.EntityFrameworkCore;

namespace FleetBattles.Models
{
    [Table("Factions")]
    public class Faction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FactionId { get; set; }
        [Required]
        [MaxLength(15)]
        public string ShortName { get; set; } //e.g. The Union
        [Required]
        [MaxLength(15)]
        public string Adjective { get; set; } //e.g. Union
        [Required]
        [MaxLength(35)]
        public string LongName { get; set; } //e.g. The Slah'khe Union
        [Required]
        public string IconURL { get; set; } 
        [Required]
        public string LogoURL { get; set; }
        public int RaceId { get; set; }
        public Race DefaultRace { get; set; }
        public int ChannelId { get; set; }
        public Channel DefaultChannel { get; set; }
        private List<ApplicationUser> Users { get; set; }
        public List<FactionChannel> Channels { get; set; }
        [DefaultValue(false)]
        [Required]
        public bool IsPublic { get; set; }
    }
}
