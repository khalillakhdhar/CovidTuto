using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidTuto.interfaces;

namespace CovidTuto.controllers.patients
{
    class PatientSearchImplement : RecherchePatientInterface
    {
        public void rechercherParEmailAndMdp(string email, string password, List<PatientModel> patients)
        {
            Console.WriteLine("rechercherParEmailAndMdp succesfful");
        }

        public void rechercherParId(int id, List<PatientModel> patients)
        {
            Console.WriteLine("rechercherParId");
        }

        public void rechercherParNom(string nom, List<PatientModel> patients)
        {
            Console.WriteLine("rechercherParNom");
        }
    }
}
