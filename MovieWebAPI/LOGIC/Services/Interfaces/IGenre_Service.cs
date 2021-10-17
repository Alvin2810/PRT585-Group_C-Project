using LOGIC.Services.Models;
using LOGIC.Services.Models.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IGenre_Service
    {
        /* fetch methods */
        Task<Generic_ResultSet<List<Movie_ResultSet>>> GetAllGenres();
        Task<Generic_ResultSet<Movie_ResultSet>> GetGenreById(Int64 id);

        //Task<Generic_ResultSet<Student_ResultSet>> GetStudentByName(String name); always can add extra new calls as needed, and add to its dedicated
        //dal service and interface


        /* Create/Edit/Delete methods */
        Task<Generic_ResultSet<Movie_ResultSet>> AddGenre(String name);
        Task<Generic_ResultSet<Movie_ResultSet>> UpdateGenre(Int64 id, String name);
        Task<Generic_ResultSet<bool>> DeleteGenre(Int64 id);

    }
}
