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
            //ConsoTabHeritage();
            //ConsoClasseAbstraite();
            ExerciceAbstraction();
        }

        private static void ExerciceAbstraction()
        {
            Danse Danse1 = new Danse();
            Danse1.FacturerFraisDossier();
            Danse1.ObtenirLicense();
            Danse1.Facturer();
            Danse1.Inscriptioncompetetion();
            Console.WriteLine("--------------");
            Basket Basket1 = new Basket();
            Basket1.FacturerFraisDossier();
            Basket1.ObtenirLicense();
            Basket1.Facturer();
            Basket1.Inscriptioncompetetion();




            //Appeler les 4 methodes sur un objet Danse et un Objet Basket
        }

        private static void ConsoClasseAbstraite()
        {
            Voyage v = new Treck();
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
