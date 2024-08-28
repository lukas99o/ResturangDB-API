using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ResturangDB_API.Models.DTOs
{
    public class BookingDTO
    {
        public int BookingID { get; set; }
        public int FK_CustomerID { get; set; }
        public int FK_TableID { get; set; }
        public int AmountOfPeople { get; set; }

        [JsonIgnore]
        public DateTime BookingDay { get; set; }

        [JsonIgnore]
        public DateTime BookingTime { get; set; }

        [JsonIgnore]
        public DateTime BookingTimeEnd { get; set; }

        public string FormattedBookingDay => BookingDay.ToString("yyyy-MM-dd");
        public string FormattedBookingTime => BookingTime.ToString("HH:mm");
        public string FormattedBookingTimeEnd => BookingTimeEnd.ToString("HH:mm");
    }
}
