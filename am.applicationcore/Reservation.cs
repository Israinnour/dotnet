using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }

        public virtual Seat Seat { get; set; }
        public int SeatFk { get; set; }
        public String PassengerFk { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
