using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Interfaces
{
    public interface ITheatre_Operations
    {
        Task<Theatre> Create(Theatre objectToAdd);
        Task<Theatre> Read(Int64 entityId);
        Task<List<Theatre>> ReadAll();
        Task<Theatre> Update(Theatre objectToUpdate, Int64 entityId);
        Task<bool> Delete(Int64 entityId);
    }
}