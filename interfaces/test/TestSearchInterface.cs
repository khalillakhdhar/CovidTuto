using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto.interfaces
{
    interface TestSearchInterface
    {
        void searchReportPatientById(int idPatient, List<TestModel>);
        void searchRapportPositif(List<TestModel>);
    }
}
