using AM.ApplicationCore;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        

        public DbSet<Flight>Flights{get; set; }
        public DbSet<Passenger>Pasengers{ get; set; }
        public DbSet<Staff>Staffs{ get; set; }
        public DbSet<Traveller>Travellers{ get; set; }

        public DbSet<Plane>Planes{ get; set; }


        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source= (localdb)\mssqllocaldb;"
          + "initial catalog= israneji; integrated security =true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //config fluentAPI
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());  
        }
    }
}
