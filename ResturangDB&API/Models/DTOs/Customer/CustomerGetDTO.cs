﻿namespace ResturangDB_API.Models.DTOs.Customer
{
    public class CustomerGetDTO
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}