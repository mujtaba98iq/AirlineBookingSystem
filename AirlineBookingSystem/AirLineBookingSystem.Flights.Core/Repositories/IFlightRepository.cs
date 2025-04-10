﻿using AirLineBookingSystem.Flights.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineBookingSystem.Flights.Core.Repositories
{
    public interface IFlightRepository
    {
        Task <IEnumerable<Flight>> GetFlightAsync (); 
        Task AddFlightAsync (Flight flight);
        Task DeleteFlightAsync (Guid id);
         
    }
}
