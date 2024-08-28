using Microsoft.AspNetCore.Mvc;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Controllers
{
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpPost]
        [Route("CreateMenuItem")]
        public async Task<ActionResult> CreateMenuItem(MenuItemDTO menuItem)
        {
            await _menuItemService.AddMenuItemAsync(menuItem);
            return Created();
        }

        [HttpGet]
        [Route("GetAllMenuItems")]
        public async Task<ActionResult<IEnumerable<MenuItemDTO>>> GetAllMenuItems()
        {
            var menuItemList = await _menuItemService.GetAllMenuItemsAsync();
            return Ok(menuItemList);
        }

        [HttpGet]
        [Route("GetSpecificMenuItem")]
        public async Task<ActionResult> GetSpecificMenuItem(int menuItemID)
        {
            var menuItem = await _menuItemService.GetMenuItemByIdAsync(menuItemID);
            return Ok(menuItem);
        }

        [HttpPut]
        [Route("UpdateMenuItem")]
        public async Task<ActionResult> UpdateSpecificMenuItem(MenuItemDTO menuItem)
        {
            await _menuItemService.UpdateMenuItemAsync(menuItem);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteMenuItem")]
        public async Task<ActionResult> DeleteSpecificMenuItem(int menuItemID)
        {
            await _menuItemService.DeleteMenuItemAsync(menuItemID);
            return Ok();
        }
    }
}
