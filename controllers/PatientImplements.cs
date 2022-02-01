using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidTuto.interfaces;

namespace CovidTuto.controllers
{
    class PatientImplements : PatientInterface
    {
        public void afficherPatient(List<PatientModel> patients)
        {
            foreach (var pt in patients)
            {
                Console.WriteLine(pt.ToString());
            }
                
           }

        public void ajouterPatient(PatientModel patient)
        {
            Console.WriteLine("patient ajouté : " + patient.ToString());
        }
    }
}
