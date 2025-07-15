using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlightManagement.Domain.Entities;

namespace FlightManagement.Application.Interfaces
{
    public interface IFlightRepository
    {
        Task<Flight> AddFlightAsync(Flight flight);
        Task<Flight?> GetFlightByIdAsync(int id);
        Task<IEnumerable<Flight>> GetAllFlightsAsync();
        Task UpdateFlightAsync(Flight flight);
        Task DeleteFlightAsync(int id);
    }
}
