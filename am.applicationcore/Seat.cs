using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [StringLength(1), Required(ErrorMessage = "isRequired")]
        public string? Name { get; set; }
        public string? SeatNumber { get; set; }
        [Range(0,20)]
        public int Size { get; set; }
        public virtual Plane? Plane { get; set; }
        public int? PlaneFK { get; set; }
        public virtual Section? Section { get; set; }
        public int? SectionFK { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
