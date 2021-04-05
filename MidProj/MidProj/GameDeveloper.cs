using System;
using System.Collections.Generic;

#nullable disable

namespace MidProjData
{
    public partial class GameDeveloper
    {
        public int DeveloperId { get; set; }
        public int GameId { get; set; }

        public virtual Developer Developer { get; set; }
    }
}
