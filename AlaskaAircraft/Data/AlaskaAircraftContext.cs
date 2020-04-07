using Microsoft.EntityFrameworkCore;
using AlaskaAircraft.Models;

namespace AlaskaAircraft.Data
{
    public class AlaskaAircraftContext : DbContext
    {
        public AlaskaAircraftContext(DbContextOptions<AlaskaAircraftContext> options)
            : base(options)
        {
        }

        public DbSet<Aircraft> Aircraft { get; set; }
    }
}