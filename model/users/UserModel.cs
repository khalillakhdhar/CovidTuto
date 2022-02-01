using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto
{
    class UserModel
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int age { get; set; }

        public UserModel(int id, string nom, string prenom, string email, string password, int age)
        {
            this.id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            this.age = age;
        }

        public UserModel()
        {
        }
    }
}
