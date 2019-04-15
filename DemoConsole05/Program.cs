using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoHeritage();
            ConsoTabHeritage();
        }

        private static void ConsoTabHeritage()
        {
            Vehicule veh1 = new Vehicule();
            Voiture voit1 = new Voiture();
            List<Vehicule> lstVehicule = new List<Vehicule>() { veh1,voit1};
            foreach (IVehicule item in lstVehicule)
            {
                item.Rouler();
                item.Freiner();
            }
        }

        private static void ConsoHeritage()
        {
            Vehicule veh1 = new Vehicule();
            Voiture voit1 = new Voiture();
            veh1.Rouler();
            voit1.Rouler();
            voit1.Claxonner();
            voit1.Freiner();

        }
    }
}
