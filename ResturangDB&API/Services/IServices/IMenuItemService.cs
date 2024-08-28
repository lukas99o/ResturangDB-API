using ResturangDB_API.Models.DTOs;

namespace ResturangDB_API.Services.IServices
{
    public interface IMenuItemService
    {
        Task AddMenuItemAsync(MenuItemDTO menuItem);
        Task<IEnumerable<MenuItemDTO>> GetAllMenuItemsAsync();
        Task<MenuItemDTO> GetMenuItemByIdAsync(int menuItemID);
        Task UpdateMenuItemAsync(MenuItemDTO menuItem);
        Task DeleteMenuItemAsync(int menuItemID);
    }
}
