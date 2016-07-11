using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace FleetBattles.Models
{
    public class ChatMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; }

        [Required]
        public string Message { get; set; }

    }

}
