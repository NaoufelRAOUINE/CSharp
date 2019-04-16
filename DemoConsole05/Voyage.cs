using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    public abstract class Voyage
    {
        public void Decrire()
        {
            Console.WriteLine("Un si beau voyage");
        }

        public abstract void Reserver();
    }

    public class Treck : Voyage
    {
        public override void Reserver()
        {
            Console.WriteLine("Preparez vos chaussures, vous inscrit sur le treck");
        }
    }
}
