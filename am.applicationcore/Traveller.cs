﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public Traveller() { }
        //q11
        //b
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a traveller");
        }
    }
}
