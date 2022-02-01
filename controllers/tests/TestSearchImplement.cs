using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidTuto.interfaces;
namespace CovidTuto.controllers
{
    class TestSearchImplement : TestSearchInterface
    {
        public void searchRapportPositif(List<TestModel> testes)
        {
            Console.WriteLine("searchRapportPositif ");
        }

        public void searchReportPatientById(int idPatient, List<TestModel> testes)
        {
            Console.WriteLine("searchReportPatientById");
        }
    }
}
