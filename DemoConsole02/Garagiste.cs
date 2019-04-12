using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
    class Garagiste
    {
        string nom;


        public int Specialite { get; set; }

        public Garagiste(string nomGaragiste)
        {
            Nom = nomGaragiste;
        }

        public Garagiste()
        {
            Nom = "Inconnu";
        }
        public string Nom
        {
            get { return nom; }
            set { nom = (value.Length <= 12) ? value : nom; }
        }

        public int Reparer(Vehicule vehicule)
        {
            
                if (vehicule.Cylindree > 2000)
                {
                throw new Exception("Désolé votre vehicule depasse 2000 cm3, on ne peut pas la reparer");
                }
            return (vehicule.Cylindree < 1000) ? 200 : 300;
                




        }


    }
}
