﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineBookingSystem.Bookings.Core.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }  
        public Guid FlightId { get; set; }
        public string PassengerName { get; set; }
        public string SeatNumber { get; set; }
        public string BookingDate { get; set; }
    }
}
