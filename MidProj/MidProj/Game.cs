using System;
using System.Collections.Generic;

#nullable disable

namespace MidProjData
{
    public partial class Game
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Rating { get; set; }
    }
}
