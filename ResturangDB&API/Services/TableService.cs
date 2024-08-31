using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepo _tableRepo;

        public TableService(ITableRepo tableRepo)
        {
            _tableRepo = tableRepo;
        }

        public async Task AddTableAsync(TableDTO table)
        {
            var newTable = new Table
            {
                TableID = table.TableID,
                TableNumber = table.TableNumber,
                TableSeats = table.TableSeats,
                IsAvailable = table.IsAvailable
            };

            await _tableRepo.AddTableAsync(newTable);
        }

        public async Task<IEnumerable<TableDTO>> GetAllTablesAsync()
        {
            var tableList = await _tableRepo.GetAllTablesAsync();
            return tableList.Select(table => new TableDTO
            {
                TableID = table.TableID,
                TableNumber = table.TableNumber,
                TableSeats = table.TableSeats,
                IsAvailable = table.IsAvailable
            }).ToList();
        }

        public async Task<TableDTO> GetTableByIdAsync(int tableID)
        {
            var table = await _tableRepo.GetTableByIDAsync(tableID);

            if (table == null)
            {
                return null;
            }

            return new TableDTO
            {
                TableID = table.TableID,
                TableNumber = table.TableNumber,
                TableSeats = table.TableSeats,
                IsAvailable = table.IsAvailable
            };
        }

        public async Task UpdateTableAsync(TableDTO table)
        {
            var updatedTable = new Table
            {
                TableID = table.TableID,
                TableNumber = table.TableNumber,
                TableSeats = table.TableSeats,
                IsAvailable = table.IsAvailable
            };

            await _tableRepo.UpdateTableAsync(updatedTable);
        }

        public async Task DeleteTableAsync(int tableID)
        {
            await _tableRepo.DeleteTableAsync(tableID);
        }
    }
}
