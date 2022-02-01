using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            PatientModel p1 = new PatientModel(1, "user", "user", "mail@user.com", "pass", 22,"bon");
            PatientModel p2 = new PatientModel(2, "user2", "user2", "mail@user.com2", "pass2", 22, "bon2");
            
            PatientList pl = new PatientList();
            pl.addPatient(p1);

            PatientList pl2 = new PatientList();

            pl2.addPatient(p2);
            pl.readPatients();


            TestModel t1 = new TestModel(p1, "22/1/2022", "positif");
            TestModel t2 = new TestModel(p1, "31/1/2022", "négatif");
            RapportModel.addTest(t1);
            RapportModel.addTest(t2);
            
            RapportModel.afficheTeste();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
