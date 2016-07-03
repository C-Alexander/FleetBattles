using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FleetBattles.Models
{
    public class Faction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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
      //  public Race DefaultRace { get; set; }
    }
}
