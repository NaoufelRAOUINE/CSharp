using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole04
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInterface();
            TestIcomparable();
        }

        private static void TestIcomparable()
        {
            ArrayList listePrenoms = new ArrayList { "Faycal", "soso", "toto", "Coucou" };
            listePrenoms.Sort();
            foreach (string item in listePrenoms)
            {
                Console.WriteLine(item);
            }

            ArrayList listeMotos = new ArrayList
            {
                new Moto(){Cylindree=250}
                ,new Moto(){Cylindree=125}
                ,new Moto(){Cylindree=1000}
                ,new Moto(){Cylindree=500}
                
            };

            listeMotos.Sort();

            foreach (Moto item in listeMotos)
            {
                Console.WriteLine(item.Cylindree);
            }
        }

        private static void TestInterface()
        {
            Moto motoSuzuki = new Moto();
            Voiture voitRenault = new Voiture();
            Moto motoHonda = new Moto();
            Camion camVolvo = new Camion();
            Voiture voitHonda = new Voiture();

            IVehicule[] vehParc = { motoSuzuki, voitRenault, motoHonda, camVolvo, voitHonda };

            foreach (IVehicule item in vehParc)
            {
                item.Rouler(25);
                Console.WriteLine("Points de controle: " + item.Controler());
                Console.WriteLine("Nombre des roues: "+item.byNbRoues);
                Console.WriteLine("------------------------------");
            } 
        }
    }
}
