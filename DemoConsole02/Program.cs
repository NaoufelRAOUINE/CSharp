using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
    class Program
    {

        static void Main(string[] args)
        {
            //Demo01SaisieEtConversion();
            //Exercice01CreationPseudo();
            //ValeursExtremes();
            //Palindrome("azza");
            //CasseMagique("Raouine");
            //MoyenneSpeciale(2, new double[]{ 4 , 8});
            //string[] tableau = new string[] { "aa", "bb", "aa" };
            //Distinguer(tableau);
            //NombreDejours(04,2019);
            //TableauCumulatif(new int[] { 0, 2, 4,8});
            //NomDepartement("01");
            //int v = 10;
            //demoRef(ref v);
            //Console.WriteLine(v);

            #region module04
            //Vehicule vehicule = new Vehicule();
            //vehicule._couleur = "rouge";
            //vehicule.Cylindree = 1000;
            //vehicule.Avancer(12);
            //vehicule.Avancer(20);
            //vehicule.Avancer(5);
            //vehicule.Avancer(10);
            //Console.WriteLine("Vous Roulez à "+vehicule.Vitesse);
            //Console.ReadLine();
            //vehicule.Freiner(30);
            //Console.WriteLine("Vous Roulez à " + vehicule.Vitesse);
            ////////////
            //Garagiste garagiste = new Garagiste("Gege");
            //Vehicule vehicule1 = new Vehicule();
            //vehicule1.Cylindree = 800;
            //Console.WriteLine("Le cout de reparation " + garagiste.Reparer(vehicule1));
            //Vehicule vehicule2 = new Vehicule();
            //vehicule2.Cylindree = 1600;
            //Console.WriteLine("Le cout de reparation " + garagiste.Reparer(vehicule2));
            //Vehicule vehicule3 = new Vehicule();
            //vehicule3.Cylindree = 1550;
            //Console.WriteLine("Le cout de reparation " + garagiste.Reparer(vehicule3));
            //garagiste.Nom="ss";
            //Console.WriteLine(garagiste.Nom);


            #endregion






        }

        private static void demoRef(ref int v)
        {
            v += 5;
        }




        //1
        private static void NombreDejours(int month ,int year)
        {
            var weekends = new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday };

            
            int daysInMonth = DateTime.DaysInMonth(year, month);

            IEnumerable<int> businessDaysInMonth = Enumerable.Range(1, daysInMonth)
                                                   .Where(d => !weekends.Contains(new DateTime(year, month, d).DayOfWeek));
            
            Console.WriteLine(businessDaysInMonth.ToArray().Length + " jours ouvrés");
        }
        
        //2
        private static void ValeursExtremes()
        {
            int tailleTab;
            do
            {
                Console.WriteLine("saisir la taille de tableau");

            } while (!(int.TryParse(Console.ReadLine(),out tailleTab)&&tailleTab>0));
            int[] tableau = new int[tailleTab];
            //int i = 0;
            //do
            //{

            //    Console.WriteLine("saisir la valeur n°: " + i);
            //    i++;


            //} while (!(int.TryParse(Console.ReadLine(), out tableau[i-1]) && i > tailleTab-1));
            for (int i = 0; i < tailleTab; i++)
            {
                do
                {
                    Console.WriteLine("saisir la valeur n°: " + i);
                } while (!int.TryParse(Console.ReadLine(), out tableau[i]));
                
                
            }

            Console.WriteLine("La valeur la plus hausse est: {0} et la valeur la plus basse est : {1}",
                tableau.Max(),tableau.Min());



        }

        //3
        private static string[] Distinguer(string[] tableau)
        {
            
            string[] q = tableau.Distinct().ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.WriteLine(q[i]);
            }
            return q;

        }
        
        //4
        private static double MoyenneSpeciale(double bonus,double[] tableau)
        {
            double somme = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                somme += tableau[i];
            }
            return (somme + bonus) / tableau.Length;
        }

        //5
        private static void CasseMagique(string str)
        {
            string newStr=null;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str.ElementAt(i) >= 'A' && str.ElementAt(i) <= 'Z') || str.ElementAt(i) >= 'a' && str.ElementAt(i) <= 'z')
                {
                    if (str.ElementAt(i) == 'a' || str.ElementAt(i) == 'A' || str.ElementAt(i) == 'e' || str.ElementAt(i) == 'E' || str.ElementAt(i) == 'i'
                        || str.ElementAt(i) == 'I' || str.ElementAt(i) == 'o' || str.ElementAt(i) == 'O' || str.ElementAt(i) == 'u' || str.ElementAt(i) == 'U')
                    {
                        //Console.WriteLine(str.ElementAt(i) + " is a vowel");
                        newStr += str.ElementAt(i).ToString().ToUpper();

                    }
                    else
                    {
                        //Console.WriteLine(str.ElementAt(i) + " is a consonant");
                        newStr += str.ElementAt(i).ToString().ToLower();
                    }
                }
                else
                {
                    //Console.WriteLine(str.ElementAt(i) + " is not an alphabet");
                    newStr += str.ElementAt(i).ToString();
                }
            }
            Console.WriteLine(newStr);
        }
        
        //6
        private static bool Palindrome(string myString)
        {
            return myString.ToLower().SequenceEqual(myString.ToLower().Reverse());
            //string first = myString.Substring(0, myString.Length / 2);
            //char[] arr = myString.ToCharArray();

            //Array.Reverse(arr);

            //string temp = new string(arr);
            //string second = temp.Substring(0, temp.Length / 2);

            //return first.Equals(second);
        }

        //7
        private static int[] TableauCumulatif(int[] tab)
        {
            int somme = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                somme += tab[i];
                tab[i] = somme;
                Console.WriteLine(tab[i]);
            }
            
            return tab;
        }

        //8
        private static void NomDepartement(string dep)
        {
            switch (dep)
            {
                case "01":
                    Console.WriteLine("Ain");
                    break;
                case "02":
                    Console.WriteLine("Aisne");
                    break;
                case "03":
                    Console.WriteLine("Allier");
                    break;
                case "04":
                    Console.WriteLine("Alpes-de-Haute-Provence");
                    break;
                case "05":
                    Console.WriteLine("Hautes-Alpes");
                    break;
                case "06":
                    Console.WriteLine("Alpes-Maritimes");
                    break;
                case "07":
                    Console.WriteLine("Ardèche");
                    break;
                case "08":
                    Console.WriteLine("Ardennes");
                    break;
                case "09":
                    Console.WriteLine("Ariège");
                    break;
                default:
                    break;
            }
        }




























        private static void Demo01SaisieEtConversion()
        {
            decimal[] temperatures = new decimal[4];
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = SaisieDecimal("Saisir un decimal");
                Console.WriteLine("{0} °C équivalent à {1} °F", temperatures[i], CelsiusVersFahrenheit(temperatures[i]));
            }
        }

        private static decimal SaisieDecimal(string strMessage)
        {
            decimal dSaisie;
            do
            {
                Console.WriteLine(strMessage);
            } while (!decimal.TryParse(Console.ReadLine(), out dSaisie));

            return dSaisie;
        }

        private static decimal CelsiusVersFahrenheit(decimal dCelsius)
        {
            return dCelsius * 9 / 5 + 32;
        }

        private static void Exercice01CreationPseudo()
        {
            string pseudo;
            Console.WriteLine("saisir Pseudo");
            pseudo=ValidationPseudo(Console.ReadLine());
            Console.WriteLine("Votre pseudo validé : {0}"
                , ValidationPseudo(pseudo)
                );

        }

        private static string ValidationPseudo(string pseudo)
        {
            if(pseudo.Length<8)
            {
                int nombreManquant = 8-pseudo.Length;
                Random rnd = new Random();
                int max = (int)Math.Pow(10, nombreManquant) - 1;
                int min = 0;
                pseudo += rnd.Next(min,max).ToString("D"+nombreManquant);
               

            }
            
            return pseudo;
        }
    }






}
