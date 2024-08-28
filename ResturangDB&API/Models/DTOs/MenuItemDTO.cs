using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ResturangDB_API.Models.DTOs
{
    public class MenuItemDTO
    {
        public int MenuItemID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }
        public int FK_MenuID { get; set; }
    }
}
