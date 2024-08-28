using Microsoft.AspNetCore.Mvc;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Models;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Controllers
{
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpPost]
        [Route("CreateTable")]
        public async Task<ActionResult> CreateTable(TableDTO table)
        {
            await _tableService.AddTableAsync(table);
            return Created();
        }

        [HttpGet]
        [Route("GetAllTables")]
        public async Task<ActionResult<IEnumerable<TableDTO>>> GetAllTables()
        {
            var tableList = await _tableService.GetAllTablesAsync();
            return Ok(tableList);
        }

        [HttpGet]
        [Route("GetSpecificTable")]
        public async Task<ActionResult> GetSpecificTable(int tableID)
        {
            var table = await _tableService.GetTableByIdAsync(tableID);
            return Ok(table);
        }

        [HttpPut]
        [Route("UpdateTable")]
        public async Task<ActionResult> UpdateSpecificTable(TableDTO table)
        {
            await _tableService.UpdateTableAsync(table);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteTable")]
        public async Task<ActionResult> DeleteSpecificTable(int tableID)
        {
            await _tableService.DeleteTableAsync(tableID);
            return Ok();
        }

    }
}
