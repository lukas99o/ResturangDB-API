using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs.Table;
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

        public async Task AddTableAsync(TableCreateDTO tableCreate)
        {
            var table = new Table
            {
                TableSeats = tableCreate.TableSeats,
                IsAvailable = tableCreate.IsAvailable
            };

            await _tableRepo.AddTableAsync(table);
        }

        public async Task<IEnumerable<TableGetDTO>> GetAllTablesAsync()
        {
            var tables = await _tableRepo.GetAllTablesAsync();

            var tableList = tables.Select(table => new TableGetDTO
            {
                TableID = table.TableID,
                TableSeats = table.TableSeats,
                IsAvailable = table.IsAvailable
            }).ToList();

            return tableList;
        }

        public async Task<TableGetDTO> GetTableByIdAsync(int tableID)
        {
            var tableFound = await _tableRepo.GetTableByIDAsync(tableID);

            if (tableFound != null)
            {
                var table = new TableGetDTO
                {
                    TableID = tableFound.TableID,
                    TableSeats = tableFound.TableSeats,
                    IsAvailable = tableFound.IsAvailable
                };

                return table;
            }

            return null;
        }

        public async Task<bool> UpdateTableAsync(TableUpdateDTO table)
        {
            var updatedTable = await _tableRepo.GetTableByIDAsync(table.TableID);

            if (updatedTable != null)
            {
                updatedTable.TableSeats = table.TableSeats;
                updatedTable.IsAvailable = table.IsAvailable;
                await _tableRepo.UpdateTableAsync(updatedTable);

                return true;
            }

            return false;
        }

        public async Task<bool> DeleteTableAsync(int tableID)
        {
            var foundTable = await _tableRepo.GetTableByIDAsync(tableID);

            if (foundTable != null)
            {
                await _tableRepo.DeleteTableAsync(foundTable);
                return true;
            }

            return false;
        }
    }
}
