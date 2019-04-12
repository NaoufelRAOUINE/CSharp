using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole04
{
    interface IVehicule
    {
        void Rouler(int acceleration);
        int Controler();
        byte byNbRoues { get;  }

    }
}
