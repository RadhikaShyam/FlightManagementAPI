using System;

namespace FlightManagement.Application.Dtos
{
    public class FlightDto
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; } = null!;
        public string Origin { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
    }
}
