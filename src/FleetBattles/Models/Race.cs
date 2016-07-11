using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FleetBattles.Models
{
    [Table("Races")]
    public class Race
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RaceId { get; set; }
        [Required]
        [MaxLength(15)]
        public string Name { get; set; } //e.g. The Slah'khe
        [Required]
        [MaxLength(15)]
        public string Adjective { get; set; } //e.g. Slah'khe
        [Required]
        public string AvatarURL { get; set; }
        private List<ApplicationUser> Users { get; set; }
    }
}
