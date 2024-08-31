using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;

namespace ResturangDB_API.Services.IServices
{
    public interface IMenuService
    {
        Task AddMenuAsync(MenuDTO menu);
        Task<IEnumerable<MenuDTO>> GetAllMenusAsync();
        Task<MenuDTO> GetMenuByIdAsync(int menuID);
        Task<IEnumerable<MenuItemDTO>> GetMenuItemsAsync(int menuID);
        Task UpdateMenuAsync(MenuDTO menu);
        Task DeleteMenuAsync(int menuID);
    }
}
