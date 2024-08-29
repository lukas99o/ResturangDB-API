using Microsoft.AspNetCore.Mvc;
using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Controllers
{
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpPost]
        [Route("CreateMenu")]
        public async Task<ActionResult> CreateMenu(MenuDTO menu)
        {
            await _menuService.AddMenuAsync(menu);
            return Created();
        }

        [HttpGet]
        [Route("GetAllMenus")]
        public async Task<ActionResult<IEnumerable<MenuDTO>>> GetAllMenus()
        {
            var menuList = await _menuService.GetAllMenusAsync();
            return Ok(menuList);
        }

        [HttpGet]
        [Route("GetSpecificMenu")]
        public async Task<ActionResult<MenuDTO>> GetSpecificMenu(int menuID)
        {
            var menu = await _menuService.GetMenuByIdAsync(menuID);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }

        [HttpGet]
        [Route("GetItemsFromMenu")]
        public async Task<ActionResult<MenuDTO>> GetItemsFromMenu(int menuID)
        {
            var menu = await _menuService.GetMenuByIdAsync(menuID);

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        [HttpPut]
        [Route("UpdateMenu")]
        public async Task<ActionResult> UpdateSpecificMenu(MenuDTO menu)
        {
            await _menuService.UpdateMenuAsync(menu);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteMenu")]
        public async Task<ActionResult> DeleteSpecificMenu(int menuID)
        {
            await _menuService.DeleteMenuAsync(menuID);
            return Ok();
        }

    }
}
