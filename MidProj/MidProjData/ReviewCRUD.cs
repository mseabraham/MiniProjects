using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjData;

namespace MidProjClasses
{
    public class ReviewCRUD
    {
        public void CreateReview(int gameID, int userID, string title, string content, int rating)
        {
            Review newRev = new Review {GameId = gameID, UserId = userID, Title = title, Content = content, Rating = rating };
            using (var db = new Gam3Sp0tContext())
            {
                db.Reviews.Add(newRev);
                db.SaveChanges();
            }

        }
    }
}
