using System;
using System.Collections.Generic;

#nullable disable

namespace MidTrainingProj.Models
{
    public partial class GamePlatform
    {
        public int PlatformId { get; set; }
        public int GameId { get; set; }

        public virtual Platform Platform { get; set; }
    }
}
