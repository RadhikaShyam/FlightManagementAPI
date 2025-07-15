using FlightManagement.Application.Interfaces;
using FlightManagement.Domain.Entities;
using FlightManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagement.Infrastructure.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FlightRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Flight> AddFlightAsync(Flight flight)
        {
            await _dbContext.Flights.AddAsync(flight);
            await _dbContext.SaveChangesAsync();
            return flight;
        }

        public async Task DeleteFlightAsync(int id)
        {
            var flight = await _dbContext.Flights.FindAsync(id);
            if (flight != null)
            {
                _dbContext.Flights.Remove(flight);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Flight>> GetAllFlightsAsync()
        {
            return await _dbContext.Flights.ToListAsync();
        }

        public async Task<Flight?> GetFlightByIdAsync(int id)
        {
            return await _dbContext.Flights.FindAsync(id);
        }

        public async Task UpdateFlightAsync(Flight flight)
        {
            _dbContext.Flights.Update(flight);
            await _dbContext.SaveChangesAsync();
        }
    }
}
