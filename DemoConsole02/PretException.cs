using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
    class PretException:Exception
    {
        public int Duree { get; set; }
        public double Taux { get; set; }
        public double Montant { get; set; }
    }
}
