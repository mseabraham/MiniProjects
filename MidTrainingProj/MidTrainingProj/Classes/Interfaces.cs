using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTrainingProj.Classes
{
    public interface IUpdatable
    {
        void UpdateGame(string title);

        //Need to be fixed
        void UpdateGame(string title, DateTime release);
    }
}
