using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteMovieDatabaseMaui.Models
{
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public string MovieUrl { get; set; }
        public DateTime Watched { get; set; }
        public Rating MovieRating { get; set; }
        public bool Done { get; set; }

        public enum Rating
        {
            Best8To10,
            Good6To7dot99,
            Okay4To5dot99,
            NotGood2To3dot99,
            Horrible0To199 
        }
    }
}
