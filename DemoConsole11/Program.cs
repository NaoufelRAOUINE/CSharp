using System;
using SHDocVw;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole11
{
    class Program
    {
        static void Main(string[] args)
        {

            //DemoAutomation();
            DemoGarbage();
        }

        private static void DemoGarbage()
        {
            Lecteur monLecteur = new Lecteur();
            Console.WriteLine(monLecteur.Lire());
            Console.ReadLine();
            monLecteur = null;
            Console.WriteLine("Les ressources devraient etre liberes");
            
            GC.Collect();


        }

        private static void DemoAutomation()
        {
            Process.Start("IExplore.exe", "www.google.com");
            dynamic ie = new InternetExplorer();
            ie.Visible = true;
            //ie.FullScreen = true;
            ie.Navigate("http://www.google.com");
            Console.Read();
            

        }
    }
}
