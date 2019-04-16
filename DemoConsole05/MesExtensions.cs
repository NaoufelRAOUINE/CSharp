using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    public static class MesExtensions
    {
        public static string VersChaineADeuxDecimales(this double mt)
        {

            return Math.Round(mt,2).ToString();
        }
    }
}
