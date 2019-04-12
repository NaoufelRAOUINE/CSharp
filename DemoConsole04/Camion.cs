using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole04
{
    class Camion : IVehicule
    {
        public byte byNbRoues { get => 17; }

        public int Controler()
        {
            return (new Random().Next(200, 250));
        }

        public void Rouler(int acceleration)
        {
            Console.WriteLine("Le camion accelere de {0} km/h", acceleration);
        }

        public void Bacher()
        {
            Console.WriteLine("Le camion est bien baché");
        }
    }
}
