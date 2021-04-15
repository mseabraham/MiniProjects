using System;
using System.Collections.Generic;
using System.Linq;
using MidProjData;

namespace MidProjClasses
{
    public class GameCRUD
    {
        
        public List<Game> gameFill = new List<Game>();
        public Game SelectedGame { get; set; }
        public Developer SelectedDev { get; set; }
        public Platform SelectedPlat { get; set; }

        //CREATE
        public void CreateDeveloper(string companyName)
        {
            using (var db = new Gam3Sp0tContext())
            {
                Developer dev = new Developer { CompanyName = companyName };
                db.Developers.Add(dev);
                db.SaveChanges();
            }
        }

        public void CreatePlatform(string platform, string brand)
        {
            using (var db = new Gam3Sp0tContext())
            {
                Platform plat = new Platform { PlatformName = platform, Brand = brand };
                db.Platforms.Add(plat);
                db.SaveChanges();
            }
        }

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
        public List<Game> GetGames()
        {
            using (var db = new Gam3Sp0tContext())
            {
                return db.Games.ToList();
            }

        }
        public List<Developer> GetDevelopers()
        {
            using (var db = new Gam3Sp0tContext())
            {
                return db.Developers.ToList();
            }
            
        }

        public List<Platform> GetPlatforms()
        {
            using (var db = new Gam3Sp0tContext())
            {
                return db.Platforms.ToList();
            }

        }

        //UPDATE
        public void UpdateGame(string title, DateTime release)
        {
            using (var db = new Gam3Sp0tContext())
            {
                var customer = db.Games.Where(g => g.GameTitle == SelectedGame.GameTitle).FirstOrDefault();
                customer.GameTitle = title;
                customer.ReleaseDate = release;
                db.SaveChanges();
            }
            gameFill.Clear();
            BindGames();

        }

        //DELETE
        public void DeleteGame()
        {
            using (var db = new Gam3Sp0tContext())
            {
                var deleteGame = db.Games.Find(SelectedGame.GameId);
                db.Games.RemoveRange(deleteGame);
                db.SaveChanges();
            }
        }

        public void DeleteDeveloper()
        {
            using (var db = new Gam3Sp0tContext())
            {
                var selectedDeveloper = db.Developers.Where(d => d.DeveloperId == SelectedDev.DeveloperId);
                db.Developers.RemoveRange(selectedDeveloper);
                db.SaveChanges();
            }
        }

        public void DeletePlatform()
        {
            using (var db = new Gam3Sp0tContext())
            {
                var selectedPlat = db.Platforms.Where(p => p.PlatformId == SelectedPlat.PlatformId);
                db.Platforms.RemoveRange(selectedPlat);
                db.SaveChanges();
            }
        }








    }
}
