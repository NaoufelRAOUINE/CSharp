using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Demo1 Variables
            //string strMessage = "Youpi";

            //DateTime dateCourante = DateTime.Today;

            //long lngSomme = 250000;

            //StringBuilder sbChaine = new StringBuilder();

            //Console.WriteLine(strMessage + "\n" + dateCourante + "\n" + lngSomme);

            #endregion

            DemoSystemeDefichiers();

            #region Conversions
            //int lngNbCaracteres;
            //string strMessage;

            //Console.WriteLine("saisir Message");
            //strMessage = Console.ReadLine();

            //lngNbCaracteres = (int)strMessage.LongCount();
            //Console.WriteLine("La taille de chaine est : "+ lngNbCaracteres);



            #endregion

            #region IF

            //string strSaisie;
            //int intAge;
            //decimal dTarif=100;
            //string strMessage;

            //Console.WriteLine("saisir votre Age");
            //strSaisie = Console.ReadLine();

            //if (!int.TryParse(strSaisie,out intAge))
            //{
            //    strMessage = "Mauvaises saisies";
            //}
            //else if (intAge<20)
            //{
            //    strMessage = "Moins de 20 ans";
            //    dTarif = 50;

            //}
            //else if (intAge < 60)
            //{
            //    strMessage = "Actifs";
            //    dTarif = 95;
            //}
            //else
            //{
            //    strMessage = "Retraités";
            //    dTarif = 60;
            //}

            //Console.WriteLine("Tarif: {0} pour les {1}", dTarif,strMessage);



            #endregion

            #region ex01 if
            //string strSaisie;
            //string strMessage;




            //Console.WriteLine("saisir votre Pseudo");
            //strSaisie = Console.ReadLine();

            //if (strSaisie.Length < 5)
            //{
            //    strMessage = "Mauvaises saisies";
            //}
            ////else if (!(strSaisie.Contains("z")|| strSaisie.Contains("Z")
            ////    ||strSaisie.Contains("k")|| strSaisie.Contains("K")))
            ////{
            ////    strMessage = strSaisie;

            ////}
            //else 
            //{

            //    strSaisie = strSaisie.Replace("z", "s")
            //    .Replace("Z", "S")
            //    .Replace("k", "q")
            //    .Replace("K", "Q");
            //    strMessage=strSaisie;


            //}

            //Console.WriteLine("Pseudo: {0} ", strMessage);
            //Console.Read();


            #endregion


            #region Case switch
            //string strChoix;
            //string strMessage;

            //Console.WriteLine("Votre choix");

            //Console.WriteLine("1...Partager");
            //Console.WriteLine("2...Imprimer");
            //Console.WriteLine("3...Modifier");
            //Console.WriteLine("4...Supprimer");

            //strChoix = Console.ReadLine();
            //switch(strChoix)
            //{
            //    case "1":
            //        strMessage = "Votre document va être envoyé";
            //        break;
            //    case "2":
            //        strMessage = "Votre document va être imprimé";
            //        break;
            //    case "3":
            //        strMessage = "Votre document va être modifié";
            //        break;
            //    case "4":
            //        strMessage = "Votre document va être supprimé";
            //        break;

            //    default:
            //        strMessage = "Nous n'avons pas compris";
            //        break;

            //}
            //Console.WriteLine(strMessage);


            #endregion

            #region Boucles For
            //for (int i = 0; i <= 100; i+=10)
            //{
            //    Console.WriteLine(i+" °C => "+(i* 9 / 5 + 32)+" °F");
            //}
            #endregion

            #region Ex02 For
            //Inverser une chai,e de caractere
            //string strSaisie;
            //string strChaineMiroir=null;
            //Console.WriteLine("Saisir une chaine de caractere");
            //strSaisie = Console.ReadLine();

            //for (int i = 0; i < strSaisie.Length; i++)
            //{
            //    strChaineMiroir =  strSaisie.ElementAt(i).ToString()+ strChaineMiroir ;


            //}

            //Console.WriteLine(strChaineMiroir);

            #endregion

            #region Boucles ForEach

            //DirectoryInfo dirDossier = new DirectoryInfo(@"c:\windows");

            //foreach (FileInfo fichier in dirDossier.GetFiles())
            //{
            //    Console.WriteLine(fichier);
            //}
            #endregion




            #region Ex03 Foreach
            //Afficher les fichier qui une taille > 5000 octets
            //DirectoryInfo dirDossier = new DirectoryInfo(@"c:\windows");

            //foreach (FileInfo fichier in dirDossier.GetFiles())
            //{
            //    if(fichier.Length>50000)
            //    Console.WriteLine("{0}...{1:N2}",fichier.Name,fichier.Length/1024D);
            //}
            #endregion


            #region Demo9 do loop 
            //decimal ht;
            //decimal ttc;
            //do
            //{
            //    Console.WriteLine("saisir un montant ht");

            //} while (!decimal.TryParse(Console.ReadLine(), out ht));

            //ttc = ht * 1.2M;
            //Console.WriteLine("ttc: "+ttc);
            #endregion

            #region Ex04 Do while
            //DateTime date;
            //do
            //{
            //    Console.WriteLine("saisir une date dd/MM/yyyy");


            //} while (!(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            //||((date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday)));

            //Console.WriteLine("Date validée ");
            #endregion

            #region Demo10 tableaux
            string[] prenoms = new string[14];
            prenoms[6] = "Adib";
            #endregion




































        }

        static void DemoSystemeDefichiers()
        {
            #region Demo2 Utilisation des objets
            string strNomDossier;
            string strNomFichier;
            string strMessage;
            DirectoryInfo dirDossier;
            StreamWriter streamFichier;

            Console.WriteLine("Merci d'indiquer le nom du dossier : ");
            strNomDossier = Console.ReadLine();
            Console.WriteLine("Merci d'indiquer le nom du fichier : ");
            strNomFichier = Console.ReadLine();
            Console.WriteLine("Merci d'indiquer votre texte : ");
            strMessage = Console.ReadLine();

            //creation du dossier
            dirDossier = Directory.CreateDirectory(@"c:\" + strNomDossier);

            //creation du fichier
            streamFichier = File.CreateText(dirDossier.FullName + "\\" + strNomFichier);

            //ecriture dans le fichier
            streamFichier.WriteLine(strMessage);
            streamFichier.Flush();
            streamFichier.Close();

            //confirmation
            Console.WriteLine("Le fichier " + strNomFichier + " a été crée dans le dossier " + dirDossier.FullName + " !!!! ");

            #endregion
        }

        static private string SaisirChaine(string message)
        {
            string strChaine;
            Console.WriteLine(message);
            strChaine = Console.ReadLine();
            return strChaine;

        }

    }
}
 






