using System;
using System.Collections;
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
            //TestInterface();
            //TestIcomparable();
            //TestGeneriques();
            TestCollectionsGenerique();

        }

        private static void TestCollectionsGenerique()
        {
            //utilisation d'un dictionnaire generique
            List<string> lstPrenoms = new List<string> { "Agnes", "Boumedene", "Bogdan" };
            Console.WriteLine(lstPrenoms[1]);

            Dictionary<int, string> dicoPrenoms = new Dictionary<int, string>
            { { 17, "Joffrey" },{ 12, "Billele" },{ 31,"Salam"} };
            Console.WriteLine(dicoPrenoms[12]);
        }

        private static void TestGeneriques()
        {
            string strChaineA = "Anette aime la danette";
            string strChaineB = "Naoufel aime la caramel";
            string strChaineC = "Bogdan aime les bananes";

            string[] strPrenoms = { strChaineA, strChaineB, strChaineC };

            string[] strPrenomsRenverse = Renverse<string>(strPrenoms);

            foreach (var item in strPrenomsRenverse)
            {
                Console.WriteLine(item);
            }
        }

        private static T[] Renverse<T>(T[] strPrenoms)
        {
            //utilisation des types generique
            T[] retour = new T[strPrenoms.Length];
            int intCompteur = strPrenoms.Length - 1;
            foreach (T item in strPrenoms)
            {
                retour[intCompteur] = item;
                intCompteur--;
            }
            return retour;
        }

        private static void TestIcomparable()
        {
            ArrayList listePrenoms = new ArrayList { "Faycal", "soso", "toto", "Coucou" };
            listePrenoms.Sort();
            foreach (string item in listePrenoms)
            {
                Console.WriteLine(item);
            }

            ArrayList listeMotos = new ArrayList
            {
                new Moto(){Cylindree=250}
                ,new Moto(){Cylindree=125}
                ,new Moto(){Cylindree=1000}
                ,new Moto(){Cylindree=500}
                
            };

            listeMotos.Sort();

            foreach (Moto item in listeMotos)
            {
                Console.WriteLine(item.Cylindree);
            }
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
                //Console.WriteLine("Points de controle: " + item.Controler());
                //Console.WriteLine("Nombre des roues: "+item.byNbRoues);
                //Console.WriteLine("------------------------------");
            } 
        }
    }
}
