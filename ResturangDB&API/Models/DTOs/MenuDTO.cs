namespace ResturangDB_API.Models.DTOs
{
    public class MenuDTO
    {
        public int MenuID { get; set; }
        public string Name { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
