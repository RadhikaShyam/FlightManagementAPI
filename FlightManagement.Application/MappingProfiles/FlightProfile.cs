using AutoMapper;
using FlightManagement.Application.Dtos;
using FlightManagement.Domain.Entities;

namespace FlightManagement.Application.MappingProfiles
{
    public class FlightProfile : Profile
    {
        public FlightProfile()
        {
            CreateMap<CreateFlightDto, Flight>();
            CreateMap<Flight, FlightDto>();
        }
    }
}
