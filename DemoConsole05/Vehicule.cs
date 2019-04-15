using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    class Vehicule : IVehicule
    {
        public virtual void Freiner()
        {
            Console.WriteLine("Le vehicule freine");
        }

        public void Rouler()
        {
            Console.WriteLine("Le vehicule roule");
        }
    }

    class Voiture:Vehicule
    {
        public void Claxonner()
        {
            Console.WriteLine("La voiture claxonne !!");
        }
        public override void Freiner()
        {
           // base.Freiner();
            Console.WriteLine("La voiture freine");
        }
        
    }
}
