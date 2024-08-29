using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Models;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepo _menuRepo;

        public MenuService(IMenuRepo menuRepo)
        {
            _menuRepo = menuRepo;
        }

        public async Task AddMenuAsync(MenuDTO menu)
        {
            var newMenu = new Menu
            {
                MenuID = menu.MenuID,
                Name = menu.Name
            };

            await _menuRepo.AddMenuAsync(newMenu);
        }

        public async Task<IEnumerable<MenuDTO>> GetAllMenusAsync()
        {
            var menuList = await _menuRepo.GetAllMenusAsync();
            return menuList.Select(menu => new MenuDTO
            {
                MenuID = menu.MenuID,
                Name = menu.Name
            }).ToList();
        }

        public async Task<MenuDTO> GetMenuByIdAsync(int menuID)
        {
            var menu = await _menuRepo.GetMenuByIdAsync(menuID);

            if (menu == null)
            {
                return null;
            }

            return new MenuDTO
            {
                MenuID = menu.MenuID,
                Name = menu.Name
            };
        }

        public async Task<MenuDTO> GetAllItemsFromMenu(int menuID)
        {
            var menu = await _menuRepo.GetMenuByIdAsync(menuID);

            if (menu == null)
            {
                return null;
            }

            
        }

        public async Task UpdateMenuAsync(MenuDTO menu)
        {
            var updatedMenu = new Menu
            {
                MenuID = menu.MenuID,
                Name = menu.Name
            };

            await _menuRepo.UpdateMenuAsync(updatedMenu);
        }

        public async Task DeleteMenuAsync(int menuID)
        {
            await _menuRepo.DeleteMenuAsync(menuID);
        }
    }
}
