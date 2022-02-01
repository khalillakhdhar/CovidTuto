using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidTuto.interfaces;
namespace CovidTuto.controllers
{
    class RapportImplements : RapportInterface
    {
        public void afficher(List<RapportModel> rapports)
        {
            foreach (var rp in rapports)
            {
                Console.WriteLine(rp.ToString());

            }
        }

        public void ajouter(RapportModel rapport)
        {
            Console.WriteLine("rapport ajouté: " + rapport.ToString());
        }
    }
}
