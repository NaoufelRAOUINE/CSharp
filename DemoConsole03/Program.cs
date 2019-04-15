using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole03
{
    enum Niveaux
    {
        TresFacile = 4,
        Facile = 145,
        Moyen = 827,
        Difficile = 2000,
        TresDifficile = 3000
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            //TestEnumeration();
            //TestOuvertureFichierAvecEnum();
            //TestDeStructure();
            TestIndexer();
        }

        private static void TestIndexer()
        {
            Jeu jDames = new Jeu { Titre = "Jeu de dames",Duree = Durees.Court,  Niveau = Niveaux.Moyen };
            jDames.Joueurs.Add("Bogdan");
            jDames.Joueurs.Add("Naoufel");
            //Recuperation d'un nom de joueurs en considerant la variable jDames comme
            // un tableau indexé
            Console.WriteLine(jDames[1]);
        }

        private static void TestDeStructure()
        {
            Jeu j1 = new Jeu { Duree = Durees.Court, Titre = "J1", Niveau = Niveaux.Facile };
            Jeu j2 = j1;

            Epreuve e1= new Epreuve { Duree = Durees.Court, Titre = "E1", Difficulte = Niveaux.Facile };
            Epreuve e2 = e1;
            Console.WriteLine("Avant modification");
            Console.WriteLine(j1.Titre);
            Console.WriteLine(j2.Titre);
            Console.WriteLine(e1.Titre);
            Console.WriteLine(e2.Titre);

            j1.Titre = "Jeu 1";
            e1.Titre = "Epreuve 1";
            Console.WriteLine("Apres modification");
            Console.WriteLine(j1.Titre);
            Console.WriteLine(j2.Titre);
            Console.WriteLine(e1.Titre);
            Console.WriteLine(e2.Titre);
        }

        private static void TestOuvertureFichierAvecEnum()
        {
            FileStream fs = File.Open(@"c:\Microsoft\TopSecret",
                            FileMode.Create,
                            FileAccess.Write,
                            FileShare.None

                );
                
        }

        private static void TestEnumeration()
        {
            Jeu jTest = new Jeu() { Titre = "Algorithme fou", Niveau = Niveaux.TresDifficile, Duree=Durees.Interminable };
            Console.WriteLine("Score: "+jTest.Scorer());
            

        }
    }
}
