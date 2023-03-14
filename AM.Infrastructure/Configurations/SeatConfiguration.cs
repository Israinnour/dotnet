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
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            
            //one to many
            builder
                .HasOne(s => s.Section)
                .WithMany(sc => sc.Seats)
                .HasForeignKey(s => s.SectionFK)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
