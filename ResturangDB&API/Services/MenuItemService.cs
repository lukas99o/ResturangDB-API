using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Models;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepo _menuItemRepo;

        public MenuItemService(IMenuItemRepo menuItemRepo)
        {
            _menuItemRepo = menuItemRepo;
        }

        public async Task AddMenuItemAsync(MenuItemDTO menuItem)
        {
            var newMenuItem = new MenuItem
            {
                MenuItemID = menuItem.MenuItemID,
                Name = menuItem.Name,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable,
                FK_MenuID = menuItem.FK_MenuID
            };

            await _menuItemRepo.AddMenuItemAsync(newMenuItem);
        }

        public async Task<IEnumerable<MenuItemDTO>> GetAllMenuItemsAsync()
        {
            var menuItemList = await _menuItemRepo.GetAllMenuItemsAsync();
            return menuItemList.Select(menuItem => new MenuItemDTO
            {
                MenuItemID = menuItem.MenuItemID,
                Name = menuItem.Name,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable
            }).ToList();
        }

        public async Task<MenuItemDTO> GetMenuItemByIdAsync(int menuItemID)
        {
            var menuItem = await _menuItemRepo.GetMenuItemByIDAsync(menuItemID);

            if (menuItem == null)
            {
                return null;
            }

            return new MenuItemDTO
            {
                MenuItemID = menuItem.MenuItemID,
                Name = menuItem.Name,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable
            };
        }

        public async Task UpdateMenuItemAsync(MenuItemDTO menuItem)
        {
            var updatedMenuItem = new MenuItem
            {
                MenuItemID = menuItem.MenuItemID,
                Name = menuItem.Name,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable
            };

            await _menuItemRepo.UpdateMenuItemAsync(updatedMenuItem);
        }

        public async Task DeleteMenuItemAsync(int menuItemID)
        {
            await _menuItemRepo.DeleteMenuItemAsync(menuItemID);
        }
    }
}
