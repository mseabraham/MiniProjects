using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTrainingProj.Classes
{
    public class Game
    {
     
        public Game() { }
        public Game(string title, string developer, DateTime release, int rating)
        {
            this.Title = title;
            this.Developer = developer;
            this.ReleaseDate = release;
            this.Rating = rating;
        }

        public string Title { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public Dictionary<string,bool> Platforms{ get; set; }

    }
}
