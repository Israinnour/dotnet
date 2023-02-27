using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {

        public static int Add(this int a , int b)
        {
            return a + b;
        }

        public static void UpperFullName(this Passenger passenger)
        {
            passenger.FirstName = passenger.FirstName[0].ToString().ToUpper()+ passenger.FirstName.Substring(1);
            passenger.LastName = passenger.LastName[0].ToString().ToUpper() + passenger.FirstName.Substring(1);
        }

    }
}
