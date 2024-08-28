using System.ComponentModel.DataAnnotations;

namespace ResturangDB_API.Models.DTOs
{
    public class TableDTO
    {
        public int TableID { get; set; }
        public int TableSeats { get; set; }
        public int TableNumber { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
