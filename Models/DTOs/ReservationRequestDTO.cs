﻿using System.Runtime.InteropServices;

namespace _2024_airbnb_herkansing.Models.DTOs
{
    public class ReservationRequestDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationId { get; set; }
        public float? Discount { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
