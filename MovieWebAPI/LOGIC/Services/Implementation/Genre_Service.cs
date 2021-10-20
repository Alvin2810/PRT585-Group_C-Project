using DAL.Entities;
using DAL.Functions.Interfaces;
using DAL.Functions.Specific;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.Genre;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGIC.Services.Implementation
{
    /// <summary>
    /// This service allows us to Add, Fetch and Update Genre Genre Data
    /// </summary>
    public class Genre_Service : IGenre_Service
    {
        //Reference to our crud functions
        private IGenre_Operations _Genre_operations = new Genre_Operations();

        /// <summary>
        /// Obtains all the Genre Genrees that exist in the database
        /// </summary>
        /// <returns></returns>
        public async Task<Generic_ResultSet<List<Genre_ResultSet>>> GetAllGenres()
        {
            Generic_ResultSet<List<Genre_ResultSet>> result = new Generic_ResultSet<List<Genre_ResultSet>>();
            try
            {
                //GET ALL Genre
                List<Genre> Genres = await _Genre_operations.ReadAll();
                //MAP DB Genre RESULTS
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
                result.userMessage = string.Format("All Genre Genres obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Genre_Service: GetAllGenres() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch all the required Genre Genres from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Genre_Service: GetAllGenres(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<Genre_ResultSet>> GetGenreById(long id)
        {
            Generic_ResultSet<Genre_ResultSet> result = new Generic_ResultSet<Genre_ResultSet>();
            try
            {
                //GET by ID Genre 
                var Genre = await _Genre_operations.Read(id);

                //MAP DB Genre RESULTS
                result.result_set = new Genre_ResultSet
                {
                    genre_id = Genre.GenreId,
                    name = Genre.Genre_Name,
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("Get ByID - Genre  obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Genre_Service: Get ByID() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch Get ByID the required Genre  from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Genre_Service: Get ByID(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        /// <summary>
        /// Adds a new Genre to the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Genre_ResultSet>> AddGenre(String name)
        {
            Generic_ResultSet<Genre_ResultSet> result = new Generic_ResultSet<Genre_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Genre
                Genre Genre = new Genre
                {
                    Genre_Name = name,
                };

                //ADD Genre TO DB
                Genre = await _Genre_operations.Create(Genre);

                //MANUAL MAPPING OF RETURNED Genre VALUES TO OUR Genre_ResultSet
                Genre_ResultSet GenreAdded = new Genre_ResultSet
                {
                    name = Genre.Genre_Name,
                    genre_id = Genre.GenreId,

                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Genre Genre {0} was added successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Genre_Service: AddGenre() method executed successfully.";
                result.result_set = GenreAdded;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to register your information for the Genre Genre supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Genre_Service: AddGenre(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        /// <summary>
        /// Updat an Genre Genres name.
        /// </summary>
        /// <param name="Genre_id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Genre_ResultSet>> UpdateGenre(Int64 Genre_id, String name)
        {
            Generic_ResultSet<Genre_ResultSet> result = new Generic_ResultSet<Genre_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Genre
                Genre Genre = new Genre
                {
                    GenreId = Genre_id,
                    Genre_Name = name,

                    //Genre_ModifiedDate = DateTime.UtcNow 
                };

                //UPDATE Genre IN DB
                Genre = await _Genre_operations.Update(Genre, Genre_id);

                //MANUAL MAPPING OF RETURNED Genre VALUES TO OUR Genre_ResultSet
                Genre_ResultSet GenreUpdated = new Genre_ResultSet
                {
                    name = Genre.Genre_Name,
                    genre_id = Genre.GenreId,


                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Genre Genre {0} was updated successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Genre_Service: UpdateGenre() method executed successfully.";
                result.result_set = GenreUpdated;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to update your information for the Genre Genre supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Genre_Service: UpdateGenre(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<bool>> DeleteGenre(long Genre_id)
        {
            Generic_ResultSet<bool> result = new Generic_ResultSet<bool>();
            try
            {
                //delete Genre IN DB
                var GenreDeleted = await _Genre_operations.Delete(Genre_id);

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Genre Genre {0} was deleted successfully", Genre_id);
                result.internalMessage = "LOGIC.Services.Implementation.Genre_Service: DeleteGenre() method executed successfully.";
                result.result_set = GenreDeleted;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to Delete your information for the Genre Genre supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Genre_Service: DeleteGenre(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

    }
}