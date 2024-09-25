using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models;
using ResturangDB_API.Services.IServices;
using ResturangDB_API.Models.DTOs.MenuItem;

namespace ResturangDB_API.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepo _menuItemRepo;

        public MenuItemService(IMenuItemRepo menuItemRepo)
        {
            _menuItemRepo = menuItemRepo;
        }

        public async Task AddMenuItemAsync(MenuItemCreateDTO menuItemCreate)
        {
            var menuItem = new MenuItem
            {
                Name = menuItemCreate.Name,
                Price = menuItemCreate.Price,
                IsAvailable = menuItemCreate.IsAvailable,
                FK_MenuID = menuItemCreate.MenuID
            };

            await _menuItemRepo.AddMenuItemAsync(menuItem);
        }

        public async Task<IEnumerable<MenuItemGetDTO>> GetAllMenuItemsAsync()
        {
            var menuItems = await _menuItemRepo.GetAllMenuItemsAsync();

            var menuItemList = menuItems.Select(menuItem => new MenuItemGetDTO
            {
                MenuItemID = menuItem.MenuItemID,
                MenuID = menuItem.FK_MenuID,
                Name = menuItem.Name,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable
            }).ToList();

            return menuItemList;
        }

        public async Task<MenuItemGetDTO> GetMenuItemByIdAsync(int menuItemID)
        {
            var menuItemFound = await _menuItemRepo.GetMenuItemByIDAsync(menuItemID);

            if (menuItemFound != null)
            {
                var menuItem = new MenuItemGetDTO
                {
                    MenuItemID = menuItemFound.MenuItemID,
                    MenuID = menuItemFound.FK_MenuID,
                    Name = menuItemFound.Name,
                    Price = menuItemFound.Price,
                    IsAvailable = menuItemFound.IsAvailable
                };

                return menuItem;
            }

            return null;
        }

        public async Task<bool> UpdateMenuItemAsync(MenuItemUpdateDTO menuItem)
        {
            if (string.IsNullOrEmpty(menuItem.Name))
            {
                return false;
            }

            var foundMenuItem = await _menuItemRepo.GetMenuItemByIDAsync(menuItem.MenuItemID);

            if (foundMenuItem != null)
            {
                foundMenuItem.Price = menuItem.Price;
                foundMenuItem.IsAvailable = menuItem.IsAvailable;
                await _menuItemRepo.UpdateMenuItemAsync(foundMenuItem);

                return true;
            }

            return false;
        }

        public async Task<bool> DeleteMenuItemAsync(int menuItemID)
        {
            var foundMenuItem = await _menuItemRepo.GetMenuItemByIDAsync(menuItemID);

            if (foundMenuItem != null)
            {
                await _menuItemRepo.DeleteMenuItemAsync(foundMenuItem);
                return true;
            }

            return false;
        }
    }
}
