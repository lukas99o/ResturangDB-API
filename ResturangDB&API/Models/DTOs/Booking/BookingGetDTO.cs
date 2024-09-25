﻿namespace ResturangDB_API.Models.DTOs.Booking
{
    public class BookingGetDTO
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int TableID { get; set; }
        public int AmountOfPeople { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}