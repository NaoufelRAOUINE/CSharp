using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassMethodes
{
    class Traitements
    {
        //retourne tous les denominateurs d'un nombre
        public void GetDenominateurs()
        {
            Console.WriteLine("Saisir un nombre");
            int nombre = Convert.ToInt32(Console.ReadLine());
            List<int> tab = new List<int>();
            
            for (int i = 2; i < nombre; i++)
            {
                if (nombre % i==0)
                {
                    tab.Add(i);
                }
            }
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        public void ValiderStockDeLettres(string p1, string p2)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }
        }
    }
}
