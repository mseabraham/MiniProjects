using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjData;

namespace MidProjClasses
{
    public class UserCRUD
    {
        public User SelectedUser { get; set; }
        public User LoggedIn { get; set; }

        public void CreateUser(string username, string firstName, string lastName, string password, bool isAdmin)
        {
            var newUser = new User() { Username = username, FirstName = firstName, LastName = lastName, Password = password, IsAdmin = isAdmin };
            using (var db = new Gam3Sp0tContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        public User Login(string username, string password)
        {
            using (var db = new Gam3Sp0tContext())
            {
                SelectedUser = db.Users.Where(u => u.Username == username).FirstOrDefault();

                if (SelectedUser is not null) {
                    if (SelectedUser.Password == password)
                    {
                        //sets logged in
                        LoggedIn = SelectedUser;
                        return LoggedIn;
                    }
                    else return null;
                } else return null;
                
            }
        }

        public void Update(string userName, string firstName, string lastName)
        {
            using (var db = new Gam3Sp0tContext())
            {
                SelectedUser = db.Users.Where(u => u.Username == userName).FirstOrDefault();
                SelectedUser.Username = userName;
                SelectedUser.FirstName = firstName;
                SelectedUser.LastName = lastName;
                // write changes to database
                db.SaveChanges();
            }
        }

        public void Delete()
        {

        }

        public List<User> RetrieveAll()
        {
            using (var db = new Gam3Sp0tContext())
            {
                return db.Users.ToList();
            }
        }

        
    }
}
