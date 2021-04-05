using System;
using System.Collections.Generic;
using System.Linq;
using MidProjData;

namespace MidProjClasses
{
    public class CRUD : IUpdatable
    {
        
        public List<Game> gameFill = new List<Game>();
        public Game selected = new Game();

        //READ
        public void BindGames()
        {
            using (var db = new Gam3Sp0tContext())
            {
                // FILL GAME SELECTION WITH INFORMATION OF GAMES IN THE DATABASE
                var query1 =
                    from g in db.Games
                    select g;
                foreach (var game in query1)
                {
                    gameFill.Add(game);
                }
            }
        }

        //UPDATE
        public virtual void UpdateGame(string title)
        {
            using (var db = new Gam3Sp0tContext())
            {
                var customer = db.Games.Where(g => g.GameTitle == selected.GameTitle).FirstOrDefault();
                customer.GameTitle = title;
                db.SaveChanges();
            }
            gameFill.Clear();
            BindGames();

        }

        public virtual void UpdateGame(string title, DateTime release)
        {
            using (var db = new Gam3Sp0tContext())
            {
                var customer = db.Games.Where(g => g.GameTitle == selected.GameTitle).FirstOrDefault();
                customer.GameTitle = title;
                customer.ReleaseDate = release;
                db.SaveChanges();
            }
            gameFill.Clear();
            BindGames();

        }
    }
}
