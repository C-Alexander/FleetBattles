using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FleetBattles.Models
{
    public class Race
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Name { get; set; } //e.g. The Slah'khe
        [Required]
        [MaxLength(15)]
        public string Adjective { get; set; } //e.g. Slah'khe
        [Required]
        public string AvatarURL { get; set; }
    }
}
