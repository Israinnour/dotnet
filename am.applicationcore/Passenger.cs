using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Passenger
    {
        public int PassengerId{get; set; }

        //[DisplayName("Day of Birth")]
        [Display (Name ="day of birth") , DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key, StringLength(7)]
        public string? PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        public string? EmailAdress { get; set; }
        [MinLength(3,ErrorMessage = ">3"), MaxLength(25 , ErrorMessage="<25")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [RegularExpression("[0-9]{8}")]
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

