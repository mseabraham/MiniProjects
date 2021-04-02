using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTrainingProj
{
    public class User
    {
        private int _userID;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _password;
        private bool _isAdmin;

        public User() { }

        public User(string first, string last, string user, string pass) {
            _firstName = first;
            _lastName = last;
            _userName = user;
            _password = pass;
        }

        public int UserID { get; set; }
        
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { if (value == true) _isAdmin = true; else _isAdmin = false; }
        }
    }
}
