using System;
using System.Collections.Generic;

#nullable disable

namespace MidTrainingProj.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? Rating { get; set; }

        public virtual User User { get; set; }
    }
}
