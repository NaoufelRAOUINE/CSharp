using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole04
{
    class Moto : IVehicule,IComparable
    {
        public byte byNbRoues { get => 2; }

        public int Cylindree { get; set; }

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

        public int CompareTo(object obj)
        {
            if (((Moto)obj).Cylindree<this.Cylindree)
            {
                return 1;
            }
            else if (((Moto)obj).Cylindree > this.Cylindree)
                {
                    return -1;
                }
            else
            {
                    return 0;
            }
        }
    }
}
