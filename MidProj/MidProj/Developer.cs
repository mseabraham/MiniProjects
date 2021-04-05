using System;
using System.Collections.Generic;

#nullable disable

namespace MidProjData
{
    public partial class Developer
    {
        public Developer()
        {
            GameDevelopers = new HashSet<GameDeveloper>();
        }

        public int DeveloperId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<GameDeveloper> GameDevelopers { get; set; }
    }
}
