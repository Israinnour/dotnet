using AM.ApplicationCore;


namespace atelier0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            string? nom = System.Console.ReadLine();
            System.Console.WriteLine("bonjour" + nom);
            int agevalu = 0;

            // while(agevalu == 0)
            //{
            //   var age = System.Console.ReadLine();
            // int.TryParse(age, out agevalu);
            //}
            //System.Console.WriteLine(agevalu + 1);

            do
            {
                var age = System.Console.ReadLine();
                int.TryParse(age, out agevalu);
            }
            while (agevalu == 0);
            System.Console.WriteLine(agevalu + 1);

            Personne personne = new Personne();
            Personne etudiant = new Etudiant();

            personne.Email = "email";
            personne.Nom = "nom";

            Personne p = new Personne("prenom", DateTime.Now, "nom", "pass", "conf", "email");

            Personne p2 = new Personne()
            {
                Id = 1, Nom = "nom1",
                Prenom = "prenom1",
                ConfirmPassword = "conf",
                DateNaissance = new DateTime(2023, 12, 25),
                Email = "email",
                Password = "pass"

            };

            System.Console.WriteLine(p2);
            personne.GetMyType();
            etudiant.GetMyType();

            personne.Nom = "issrainnour";

            personne.Login("pass", "conf");
            personne.Login("pass", "conf", "email");

            System.Console.WriteLine(personne.Nom);


            //Part 2 
            //q7
            Plane avion1 = new Plane();
            avion1.Capacity = 1;
            avion1.ManufactureDate = DateTime.Now;
            avion1.PlaneType = PlaneType.Airbus;
            Console.WriteLine(avion1);
            //q8
            Plane avion2 = new Plane(100, DateTime.Now, PlaneType.Airbus);

            //q9
            Plane avion3 = new Plane()
            {
                Capacity = 1,
                ManufactureDate = DateTime.Now,
                PlaneType = PlaneType.Airbus
            };
            Console.WriteLine(avion3); 

            //Part 3
            //q11
            //c
            Passenger passenger = new Passenger();
            passenger.PassengerType();
            Staff staff = new Staff();
            staff.PassengerType();
            Traveller traveller = new Traveller();
            traveller.PassengerType();
        }
    }
}