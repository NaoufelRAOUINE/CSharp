using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole04
{
    class Voiture : IVehicule
    {
        public byte byNbRoues { get => 4; }

        public int Controler()
        {
            return (new Random().Next(100, 150));
        }

        public void Rouler(int acceleration)
        {
            Console.WriteLine("La voiture accelere de {0} km/h",acceleration);
        }

        public void Atteler()
        {
            Console.WriteLine("La voiture est attelé à sa remorque");
        }
    }
}
