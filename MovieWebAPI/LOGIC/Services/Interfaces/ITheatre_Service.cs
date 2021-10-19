using LOGIC.Services.Models;
using LOGIC.Services.Models.Theatre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface ITheatre_Service
    {
        /* fetch methods */
        Task<Generic_ResultSet<List<Theatre_ResultSet>>> GetAllTheatres();
        Task<Generic_ResultSet<Theatre_ResultSet>> GetTheatreById(Int64 id);

        //Task<Generic_ResultSet<Student_ResultSet>> GetStudentByName(String name); always can add extra new calls as needed, and add to its dedicated
        //dal service and interface


        /* Create/Edit/Delete methods */
        Task<Generic_ResultSet<Theatre_ResultSet>> AddTheatre(String name);
        Task<Generic_ResultSet<Theatre_ResultSet>> UpdateTheatre(Int64 id, String name);
        Task<Generic_ResultSet<bool>> DeleteTheatre(Int64 id);

    }
}
