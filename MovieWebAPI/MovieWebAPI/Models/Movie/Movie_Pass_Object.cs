using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebAPI.Models.Movie
{
    public class Movie_Pass_Object
    {
        public Int64 movie_id { get; set; }
        public String name { get; set; }
        public String releaseDate { get; set; }
        public String language { get; set; }
    }
}
