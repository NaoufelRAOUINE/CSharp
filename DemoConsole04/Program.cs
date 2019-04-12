using System;
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
            TestInterface();
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
                //item.Controler();
                //item.byNbRoues();
            }
        }
    }
}
