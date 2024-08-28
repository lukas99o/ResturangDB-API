using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;

namespace ResturangDB_API.Services.IServices
{
    public interface ITableService
    {
        Task AddTableAsync(TableDTO table);
        Task<IEnumerable<TableDTO>> GetAllTablesAsync();
        Task<TableDTO> GetTableByIdAsync(int tableID);
        Task UpdateTableAsync(TableDTO table);
        Task DeleteTableAsync(int tableID);
    }
}
