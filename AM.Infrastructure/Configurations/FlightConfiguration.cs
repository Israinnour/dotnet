﻿using AM.ApplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.FlightId);
            builder.ToTable("vols");
            //Configurations one to many flight * et plane 1 
            builder.HasOne(f=>f.Plane).WithMany(p=>p.Flights).HasForeignKey(f=> f.PlaneFK).OnDelete(DeleteBehavior.SetNull);
            //Configurations many to many flight * et passenger *

            builder.HasMany(f => f.Passengers).WithMany(p => p.Flights).UsingEntity(pf => pf.ToTable("myPassenger"));
        }


    }
}
