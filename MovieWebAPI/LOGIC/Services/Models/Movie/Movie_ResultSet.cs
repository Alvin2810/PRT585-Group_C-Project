using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Models.Movie
{
    public class Movie_ResultSet
    {
        public Int64 movie_id { get; set; }
        public String name { get; set; }
        public String releaseDate { get; set; }
        public String language { get; set; }
    }
}

