using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string? Function { get; set; }
        public float Salary { get; set; }

        public Staff() { }

        //q11
        //b

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a staff member");
        }
    }



}
