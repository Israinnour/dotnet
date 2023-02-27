using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{

    //[Table("vols")]
    public  class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArival { get; set; }
        public int EstimatedDuration { get; set; }

        //[ForeignKey("PlaneId")]
        public  Plane? Plane { get; set; }
        [ForeignKey("Plane")]
        public int? PlaneFK { get; set; }//prop clé etranger
        public virtual List<Passenger> Passengers { get; set; }

        //6
        public override string ToString()
        {
            return "Destination : " + Destination + "Departure : " + Departure + "Flight Date " + FlightDate;

        }
    }
}
