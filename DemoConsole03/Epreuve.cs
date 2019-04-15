using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole03
{
    struct Epreuve
    {
        public Durees Duree { get; set; }
        public Niveaux Difficulte { get; set; }
        public string Titre { get; set; }

        public int Scorer()
        {
            return (int)Difficulte * 3;
        }
    }
}
