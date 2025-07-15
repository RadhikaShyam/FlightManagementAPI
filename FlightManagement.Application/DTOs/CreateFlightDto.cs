using System.ComponentModel.DataAnnotations;

namespace FlightManagement.Application.Dtos
{
    public class CreateFlightDto
    {
        [Required]
        public string FlightNumber { get; set; } = null!;

        [Required]
        public string Origin { get; set; } = null!;

        [Required]
        public string Destination { get; set; } = null!;

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
