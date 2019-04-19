using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole11
{
    class Lecteur:IDisposable
    {
        public  FileStream flux{ get; set; }
        public Lecteur()
        {
            flux = File.Open(@"C:\travail\data.txt", FileMode.Open, FileAccess.Read, FileShare.None);

        }
        public string Lire()
        {
            return "Lecture en cours";
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        ~Lecteur()
        {
            flux.Close();
            flux = null;
            Console.WriteLine("destruction");
        }
    }
}
