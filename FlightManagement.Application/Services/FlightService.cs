using AutoMapper;
using FlightManagement.Application.Dtos;
using FlightManagement.Application.Interfaces;
using FlightManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagement.Application.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public FlightService(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task<FlightDto> CreateFlightAsync(CreateFlightDto dto)
        {
            var flight = _mapper.Map<Flight>(dto);
            var created = await _flightRepository.AddFlightAsync(flight);
            return _mapper.Map<FlightDto>(created);
        }

        public async Task<bool> DeleteFlightAsync(int id)
        {
            var flight = await _flightRepository.GetFlightByIdAsync(id);
            if (flight == null) return false;

            await _flightRepository.DeleteFlightAsync(id);
            return true;
        }

        public async Task<IEnumerable<FlightDto>> GetAllFlightsAsync()
        {
            var flights = await _flightRepository.GetAllFlightsAsync();
            return _mapper.Map<IEnumerable<FlightDto>>(flights);
        }

        public async Task<FlightDto?> GetFlightByIdAsync(int id)
        {
            var flight = await _flightRepository.GetFlightByIdAsync(id);
            return flight == null ? null : _mapper.Map<FlightDto>(flight);
        }

        public async Task<bool> UpdateFlightAsync(int id, CreateFlightDto dto)
        {
            var flight = await _flightRepository.GetFlightByIdAsync(id);
            if (flight == null) return false;

            _mapper.Map(dto, flight); // Map updated properties
            await _flightRepository.UpdateFlightAsync(flight);
            return true;
        }
    }
}
