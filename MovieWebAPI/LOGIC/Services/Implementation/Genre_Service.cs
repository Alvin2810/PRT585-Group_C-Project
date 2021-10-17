using DAL.Functions.Interfaces;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Implementation
{
    class Genre_Service : IGenre_Service
    {
        /*private IGenre_Operations _Genre_operations = new Genre_Operations();*/
        public Task<Generic_ResultSet<Movie_ResultSet>> AddGenre(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Generic_ResultSet<bool>> DeleteGenre(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Generic_ResultSet<List<Movie_ResultSet>>> GetAllGenres()
        {
            throw new NotImplementedException();
        }

        public Task<Generic_ResultSet<Movie_ResultSet>> GetGenreById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Generic_ResultSet<Movie_ResultSet>> UpdateGenre(long id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
