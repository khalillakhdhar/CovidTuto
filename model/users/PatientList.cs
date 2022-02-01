using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto
{
    class PatientList
    {
        List<PatientModel> patients = new List<PatientModel>();
        public void addPatient(PatientModel pm)
        {
            patients.Add(pm);

        }





        public void readPatients()
        {
            foreach (PatientModel p in patients)
            {
                Console.WriteLine(p.Nom+" "+p.Prenom);
            }

        }
    }
}
