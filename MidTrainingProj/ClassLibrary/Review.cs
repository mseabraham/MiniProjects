using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTrainingProj.Classes
{
    public class Review
    {
        private int _reviewID;
        private int _userID;
        private string _title;
        private string _content;
        private int _ratings;
        private DateTime _postDate;

        public Review() { }

        public Review(string title, string content, int rating, DateTime post)
        {
            _title = title;
            _content = content;
            _ratings = rating;
            _postDate = post;
        }

        public int ReviewID { get; set; }

        public int ClientID { get; set; }
    }
}
