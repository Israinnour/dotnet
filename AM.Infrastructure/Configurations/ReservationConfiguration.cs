using AM.ApplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new { r.SeatFk, r.PassengerFk, r.DateReservation });
            builder.HasOne(r => r.Passenger).WithMany(r => r.Reservations).HasForeignKey(r => r.PassengerFk);
            builder.HasOne(r => r.Seat).WithMany(r => r.Reservations).HasForeignKey(r => r.SeatFk);
        }
    }
}
