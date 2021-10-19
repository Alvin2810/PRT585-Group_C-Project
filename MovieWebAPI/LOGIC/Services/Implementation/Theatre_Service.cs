using DAL.Entities;
using DAL.Functions.Interfaces;
using DAL.Functions.Specific;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.Theatre;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGIC.Services.Implementation
{
    /// <summary>
    /// This service allows us to Add, Fetch and Update Theatre Theatre Data
    /// </summary>
    public class Theatre_Service : ITheatre_Service
    {
        //Reference to our crud functions
        private ITheatre_Operations _Theatre_operations = new Theatre_Operations();
        private string name;

        /// <summary>
        /// Obtains all the Theatre Theatrees that exist in the database
        /// </summary>
        /// <returns></returns>
        public async Task<Generic_ResultSet<List<Theatre_ResultSet>>> GetAllTheatres()
        {
            Generic_ResultSet<List<Theatre_ResultSet>> result = new Generic_ResultSet<List<Theatre_ResultSet>>();
            try
            {
                //GET ALL Theatre TheatreES
                List<Theatre> Theatrees = await _Theatre_operations.ReadAll();
                //MAP DB Theatre RESULTS
                result.result_set = new List<Theatre_ResultSet>();
                Theatrees.ForEach(s =>
                {
                    result.result_set.Add(new Theatre_ResultSet
                    {
                        Theatre_id = s.TheatreId,
                        name = s.Theatre_Name,
                        
                    });
                });

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("All Theatre Theatrees obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Theatre_Service: GetAllTheatres() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch all the required Theatre Theatrees from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Theatre_Service: GetAllTheatres(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<Theatre_ResultSet>> GetTheatreById(long id)
        {
            Generic_ResultSet<Theatre_ResultSet> result = new Generic_ResultSet<Theatre_ResultSet>();
            try
            {
                //GET by ID Theatre 
                var Theatre = await _Theatre_operations.Read(id);

                //MAP DB Theatre RESULTS
                result.result_set = new Theatre_ResultSet
                {
                    Theatre_id = Theatre.TheatreId,
                    name = Theatre.Theatre_Name,
                    
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("Get ByID - Theatre  obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Theatre_Service: Get ByID() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch Get ByID the required Theatre  from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Theatre_Service: Get ByID(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        /// <summary>
        /// Adds a new Theatre to the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Theatre_ResultSet>> AddTheatre(String name)
        {
            Generic_ResultSet<Theatre_ResultSet> result = new Generic_ResultSet<Theatre_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Theatre
                Theatre Theatre = new Theatre
                {
                    Theatre_Name = name,
                    
                };

                //ADD Theatre TO DB
                Theatre = await _Theatre_operations.Create(Theatre);

                //MANUAL MAPPING OF RETURNED Theatre VALUES TO OUR Theatre_ResultSet
                Theatre_ResultSet TheatreAdded = new Theatre_ResultSet
                {
                    name = Theatre.Theatre_Name,
                    Theatre_id = Theatre.TheatreId,
                    
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Theatre Theatre {0} was added successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Theatre_Service: AddTheatre() method executed successfully.";
                result.result_set = TheatreAdded;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to register your information for the Theatre Theatre supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Theatre_Service: AddTheatre(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        /// <summary>
        /// Updat an Theatre Theatres name.
        /// </summary>
        /// <param name="Theatre_id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Theatre_ResultSet>> UpdateTheatre(Int64 Theatre_id)
        {
            Generic_ResultSet<Theatre_ResultSet> result = new Generic_ResultSet<Theatre_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Theatre
                Theatre Theatre = new Theatre
                {
                    TheatreId = Theatre_id,
                    Theatre_Name = name,
                    


                    //Theatre_ModifiedDate = DateTime.UtcNow 
                };

                //UPDATE Theatre IN DB
                Theatre = await _Theatre_operations.Update(Theatre, Theatre_id);

                //MANUAL MAPPING OF RETURNED Theatre VALUES TO OUR Theatre_ResultSet
                Theatre_ResultSet TheatreUpdated = new Theatre_ResultSet
                {
                    name = Theatre.Theatre_Name,
                    Theatre_id = Theatre.TheatreId,
                    


                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Theatre Theatre {0} was updated successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Theatre_Service: UpdateTheatre() method executed successfully.";
                result.result_set = TheatreUpdated;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to update your information for the Theatre Theatre supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Theatre_Service: UpdateTheatre(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<bool>> DeleteTheatre(long Theatre_id)
        {
            Generic_ResultSet<bool> result = new Generic_ResultSet<bool>();
            try
            {
                //delete Theatre IN DB
                var TheatreDeleted = await _Theatre_operations.Delete(Theatre_id);

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Theatre Theatre {0} was deleted successfully", Theatre_id);
                result.internalMessage = "LOGIC.Services.Implementation.Theatre_Service: DeleteTheatre() method executed successfully.";
                result.result_set = TheatreDeleted;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to Delete your information for the Theatre Theatre supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Theatre_Service: DeleteTheatre(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        public Task<Generic_ResultSet<Theatre_ResultSet>> UpdateTheatre(long id, string name)
        {
            throw new NotImplementedException();
        }
    }
}