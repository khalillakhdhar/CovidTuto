using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto
{
    class TestModel
    {
        public PatientModel patient { get; set; }
        public string Date { get; set; }
        public string Resultat { get; set; }

        public TestModel(PatientModel patient, string date, string resultat)
        {
            this.patient = patient;
            Date = date;
            Resultat = resultat;
        }

        public TestModel()
        {
        }
    }
}
