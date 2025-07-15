using FlightManagement.Application.Dtos;
using FlightManagement.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FlightManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        // GET: api/Flights
        [HttpGet]
        [Authorize] // Any authenticated user can view flights
        public async Task<IActionResult> GetFlights()
        {
            var flights = await _flightService.GetAllFlightsAsync();
            return Ok(flights);
        }

        // GET: api/Flights/{id}
        [HttpGet("{id:int}")]
        [Authorize]
        public async Task<IActionResult> GetFlight(int id)
        {
            var flight = await _flightService.GetFlightByIdAsync(id);
            if (flight == null) return NotFound();
            return Ok(flight);
        }

        // POST: api/Flights
        [HttpPost]
        [Authorize(Roles = "Admin")] // Only admin can add flights
        public async Task<IActionResult> CreateFlight([FromBody] CreateFlightDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var createdFlight = await _flightService.CreateFlightAsync(dto);
            return Ok(createdFlight);
        }

        // PUT: api/Flights/{id}
        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateFlight(int id, [FromBody] CreateFlightDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updated = await _flightService.UpdateFlightAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        // DELETE: api/Flights/{id}
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteFlight(int id)
        {
            var deleted = await _flightService.DeleteFlightAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
