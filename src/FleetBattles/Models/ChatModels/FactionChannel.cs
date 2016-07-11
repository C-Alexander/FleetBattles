using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetBattles.Models.ChatModels
{
    public class FactionChannel
    {
        public int FactionId { get; set; }
        public Faction User { get; set; }

        public int ChannelId { get; set; }
        public Channel Channel { get; set; }

    }
}
