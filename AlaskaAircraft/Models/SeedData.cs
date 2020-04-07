using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AlaskaAircraft.Data;


namespace AlaskaAircraft.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AlaskaAircraftContext
                (serviceProvider.GetRequiredService<DbContextOptions<AlaskaAircraftContext>>())) 
            {
                if (context.Aircraft.Any())
                {
                    return;
                }
                context.Aircraft.AddRange(
                    new Aircraft
                    {
                        LRU_Name = "FMC",
                        Tail_Number = "224",
                        LRU_Part_Number = "822-1604-102",
                        Software_Name = "OPS",
                        Software_Part_Number = "5569090-001",
                        EC_Number = "SB737-34-2600-NG-1",
                        Pre_Post_Condition = "y",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}