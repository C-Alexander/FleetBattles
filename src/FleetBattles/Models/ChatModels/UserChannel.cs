using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetBattles.Models.ChatModels
{
    public class UserChannel
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
    }
}
