using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Interfaces
{
    public interface IGenre_Operations
    {
        Task<Genre> Create(Genre objectToAdd);
        Task<Genre> Read(Int64 entityId);
        Task<List<Genre>> ReadAll();
        Task<Genre> Update(Genre objectToUpdate, Int64 entityId);
        Task<bool> Delete(Int64 entityId);
    }
}