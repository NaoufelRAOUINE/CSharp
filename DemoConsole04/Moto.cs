using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole04
{
    class Moto : IVehicule
    {
        public byte byNbRoues { get => 2; }

        public int Controler()
        {
            return (new Random().Next(50, 100));
        }

        public void Rouler(int acceleration)
        {
            Console.WriteLine("La Moto accelere de {0} km/h", acceleration);
        }

        public void Bequiller()
        {
            Console.WriteLine("La Bequille est en place");
        }
    }
}
