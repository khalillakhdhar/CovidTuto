using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto.interfaces
{
    interface RecherchePatientInterface
    {
        void rechercherParId(int id,List<PatientModel> patients);
        void rechercherParNom(string nom, List<PatientModel> patients);
        void rechercherParEmailAndMdp(string email, string password, List<PatientModel> patients);
    }
}
