using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto
{
    class PatientModel: UserModel
    {
        public string etat { get; set; }

        public PatientModel(string etat)
        {
            this.etat = etat;
        }

        public PatientModel(int id, string nom, string prenom, string email, string password, int age,string etat)
        {
            this.id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            this.age = age;
            this.etat = etat;
        }
    }
}
