using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Passenger
    {

        public DateTime BirthDate { get; set; }
        public string? PassportNumber { get; set; }
        public string? EmailAdress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long TelNumber { get; set; }
        public virtual List<Flight> Flights { get; set; }


        public Passenger() { }

        //6
        public override string ToString()
        {
            return "Birth Date : " + BirthDate + "First Name : " + FirstName + "Last Name : " + LastName;

        }
       

       

        //q10
        //a
        public bool CheckProfile(string FirstName, string LastName)

        {

                return this.FirstName == FirstName && this.LastName == LastName;

        }
        //b
        public bool CheckProfile1(string FirstName, string LastName, string EmailAdress)

        {

            return this.FirstName == FirstName && this.LastName == LastName && this.EmailAdress==EmailAdress;

        }
        //c
        public bool CheckProfile2(string FirstName, string LastName, string EmailAdress = null)

        {
            if (EmailAdress != null)

                return this.FirstName == FirstName && this.LastName == LastName && this.EmailAdress == EmailAdress;
            else
                return this.FirstName == FirstName && this.LastName == LastName;
        }
        //q11

        //a
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }

        


    }
}

