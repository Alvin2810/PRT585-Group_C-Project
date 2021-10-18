using DAL.Entities;
using DAL.Functions.Interfaces;
using DAL.Functions.Specific;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.Genre;
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
        private IGenre_Operations _Genre_operations = new Genre_Operations();

        public Task<Generic_ResultSet<Genre_ResultSet>> AddGenre(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Generic_ResultSet<bool>> DeleteGenre(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Generic_ResultSet<List<Genre_ResultSet>>> GetAllGenres()
        {
            Generic_ResultSet<List<Genre_ResultSet>> result = new Generic_ResultSet<List<Genre_ResultSet>>();
            try
            {
                //GET ALL Movie MovieES
                List<Genre> Genres = await _Genre_operations.ReadAll();
                //MAP DB Movie RESULTS
                result.result_set = new List<Genre_ResultSet>();
                Genres.ForEach(s =>
                {
                    result.result_set.Add(new Genre_ResultSet
                    {
                        genre_id = s.GenreId,
                        name = s.Genre_Name,

                    });
                });

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("All Movie Moviees obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Movie_Service: GetAllMovies() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch all the required Movie Moviees from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Movie_Service: GetAllMovies(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        public Task<Generic_ResultSet<Genre_ResultSet>> GetGenreById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Generic_ResultSet<Genre_ResultSet>> UpdateGenre(long id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
