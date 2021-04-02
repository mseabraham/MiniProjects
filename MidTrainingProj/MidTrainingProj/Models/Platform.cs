using System;
using System.Collections.Generic;

#nullable disable

namespace MidTrainingProj.Models
{
    public partial class Platform
    {
        public Platform()
        {
            GamePlatforms = new HashSet<GamePlatform>();
        }

        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public string Brand { get; set; }

        public virtual ICollection<GamePlatform> GamePlatforms { get; set; }
    }
}
