using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FleetBattles.Models.ChatModels;

namespace FleetBattles.Models
{
    public class Channel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChannelId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<ChatMessage> Messages { get; set; }
        [Required]
        public string Color { get; set; }
        public List<UserChannel> Users { get; set; }
        public List<FactionChannel> Factions { get; set; }
        public Boolean IsPublic { get; set; }
    }
}
