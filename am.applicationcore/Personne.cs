using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Personne
    {

        // string nom;
       public int Id { get; set; }
        public string? Prenom { get; set; }
       public DateTime DateNaissance { get; set; }

        public string? Nom { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? Email { get; set; }

       // public bool Login(string password, string confirmPassword)
       // {
       //     return this.Password == password && this.ConfirmPassword == confirmPassword;
       // }
        public bool Login (string password , string confirmPassword , string? email = null)
        {
            if (email != null)
                return this.Password == password && this.ConfirmPassword == confirmPassword && this.Email==email;
            else
                return this.Password == password && this.ConfirmPassword == confirmPassword;
        }

        public Personne()
        {

        }

        public Personne(string? prenom, DateTime dateNaissance, string? nom, string? password, string? confirmPassword, string? email)
        {
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Nom = nom;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("bonjour personne");
        }
        public override string ToString()
        {
            return $" {Id} , {Nom} , {Prenom} , {DateNaissance} ";
        }
    }
}
