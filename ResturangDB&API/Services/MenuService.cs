using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Models;
using ResturangDB_API.Services.IServices;
using System.Collections.Immutable;

namespace ResturangDB_API.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepo _menuRepo;
        private readonly IMenuItemRepo _menuItemRepo;

        public MenuService(IMenuRepo menuRepo, IMenuItemRepo menuItemRepo)
        {
            _menuRepo = menuRepo;
            _menuItemRepo = menuItemRepo;
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

        public async Task<IEnumerable<MenuItemDTO>> GetMenuItemsAsync(int menuID)
        {
            var menu = await _menuRepo.GetMenuWithItemsAsync(menuID);
            
            if (menu == null || menu.MenuItems == null)
            {
                return new List<MenuItemDTO>();
            }

            var menuItemDtos = menu.MenuItems.Select(menuItem => new MenuItemDTO
            {
                MenuItemID = menuItem.MenuItemID,
                Name = menuItem.Name,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable,
                FK_MenuID = menuItem.FK_MenuID
            }).ToList();

            return menuItemDtos;
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
