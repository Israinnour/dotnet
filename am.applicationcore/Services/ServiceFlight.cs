using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        List<DateTime> GetFlightDatess(string destination)
        {
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                Flight flight = Flights[i];
                if (flight.Destination == destination)
                {
                    result.Add(flight.FlightDate);
                }
            }
            return result;
        }

        /*IEnumerable<DateTime> GetFlightDates(string destination)
     {
         for (int i = 0; i < Flights.Count; i++)
         {
             Flight flight = Flights[i];
             if (flight.Destination == destination)
             {
                 yield return flight.FlightDate;
             }
         }
     }*/

        IEnumerable<DateTime> GetFlightDates(string destination)
        {
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    yield return flight.FlightDate;
                }
            }
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    {
                        var result = Flights.Where(f => f.Destination == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    {
                        var result = Flights.Where(f => f.Departure == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    {
                        var result = Flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightId":
                    {
                        var result = Flights.Where(f => f.FlightId == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    {
                        var result = Flights.Where(f => f.EffectiveArival == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    {
                        var result = Flights.Where(f => f.EstimatedDuration == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
            }
        }



        IEnumerable<DateTime> GetFlightDatesss(string destination)
        {
            IEnumerable<DateTime> query = Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate);

            return query;
        }

        //quest10
        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in Flights
                        where f.Plane.PlaneId == plane.PlaneId
                        select new { f.FlightDate, f.Destination };
            foreach (var item in query)
            {
                Console.WriteLine(item.Destination + item.FlightDate);
            }

        }

        //quest11
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from f in Flights
                        where ((f.FlightDate >= startDate) && (startDate - f.FlightDate).TotalDays < 7)
                        select f;
            ;


            return query.Count();


            //2eme methode
            /* return Flights.Count(f => ((f.FlightDate >= startDate) && (startDate - f.FlightDate).TotalDays < 7)
                          );*/

        }

        public double DurationAverage(string destination)
        {
            var query = from f in Flights
                        where (f.Destination == destination)
                        select f.EstimatedDuration;
            return query.Average();
        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;

            // Flights.OrderByDescending(f => f.EstimatedDuration);
        }

        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            return (from p in flight.Passengers.OfType<Traveller>()
                    orderby p.BirthDate
                    select p).Take(3).ToList();

        }

        public void DestinationGroupedFlights()
        {
            var result = from fl in Flights
                         group fl by fl.Destination;
            foreach (var grp in result)
            {
                Console.WriteLine(grp.Key);
                foreach (var flight in grp)
                {
                    Console.WriteLine(flight);
                }
            }
        }
    }
}
