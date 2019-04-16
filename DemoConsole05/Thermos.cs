using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    class Thermos
    {
        public int DureeFraicheurGarantie { get; set; }
        public int Contenance { get; set; }
        public Thermos(DateTime datedesortie)
        {
            
            DureeFraicheurGarantie = (datedesortie.Month > 4 && datedesortie.Month < 10)?4:2;
            
        }
    }
    class MiniThermos:Thermos
    {
        public MiniThermos(int c,DateTime date):base(date)
        {
            Contenance=c;
        }
        
    }
}
