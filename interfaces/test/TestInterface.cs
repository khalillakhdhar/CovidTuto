using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto.interfaces
{
    interface TestInterface
    {
        void ajouter(TestModel t);
        void afficher(List<TestModel> t);
    }
}
