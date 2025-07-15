using FlightManagement.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagement.Application.Interfaces
{
    public interface IFlightService
    {
        Task<FlightDto> CreateFlightAsync(CreateFlightDto dto);
        Task<IEnumerable<FlightDto>> GetAllFlightsAsync();
        Task<FlightDto?> GetFlightByIdAsync(int id);
        Task<bool> UpdateFlightAsync(int id, CreateFlightDto dto);
        Task<bool> DeleteFlightAsync(int id);
    }
}
