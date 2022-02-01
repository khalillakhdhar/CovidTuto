using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidTuto.interfaces;
namespace CovidTuto.controllers
{
    class TestImplement : TestInterface
    {
        public void afficher(List<TestModel> t)
        {
            foreach (var tests in t)
            {
               Console.WriteLine(t.ToString());

            }
        }

        public void ajouter(TestModel t)
        {
            Console.WriteLine(t.ToString() + " ajouté ");
        }
    }
}
