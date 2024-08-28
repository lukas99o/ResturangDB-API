using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturangDB_API.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [ForeignKey("Customer")]
        public int FK_CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Table")]
        public int FK_TableID { get; set; }
        public Table Table { get; set; }

        [Required]
        public int AmountOfPeople { get; set; }

        [Required]
        public DateTime BookingDay { get; set; }

        [Required]
        public DateTime BookingTime { get; set; }

        [Required]
        public DateTime BookingTimeEnd { get; set; }
    }
}
