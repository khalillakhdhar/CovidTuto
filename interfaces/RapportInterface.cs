using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto.interfaces
{
    interface RapportInterface
    {
        void ajouter(RapportModel rapport);
        void afficher(List<RapportModel> rapports);
    }
}
