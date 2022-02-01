using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto
{
    class RapportModel
    {
        public string Observation { get; set; }
        public static List<TestModel> testes = new List<TestModel>();
        public static void addTest(TestModel t)
        {
            testes.Add(t);
        }
        public static void afficheTeste()
        {
            foreach (TestModel ts in testes)
            {

                Console.WriteLine(ts.Date);
            }

        }

        public RapportModel(string observation)
        {
            Observation = observation;
        }
    }
}
