// Infrastructure/Data/ApplicationDbContext.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FlightManagement.Domain;
using FlightManagement.Infrastructure.Identity;
using FlightManagement.Domain.Entities;
namespace FlightManagement.Infrastructure.Persistence
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        public DbSet<Flight> Flights { get; set; }
    }
}
