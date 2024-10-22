﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ResturangDB_API.Models.DTOs.Booking
{
    public class BookingCreateDTO
    {
        public int CustomerID { get; set; }
        public int TableID { get; set; }
        public int AmountOfPeople { get; set; }
        public DateTime Time { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}
