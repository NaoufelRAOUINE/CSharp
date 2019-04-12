using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
    class Vehicule
    {
        public string _couleur;
        private int _cylindree;
        private int vitesse;


        public Vehicule(int cylindree, string couleur)
        {
            Cylindree = cylindree;
            _couleur = couleur;
        }

        public Vehicule()
        {

        }

        public int Cylindree {
            get { return _cylindree; }
            set {
                if (value>100 && value<8000)
                {
                    _cylindree = value;
                }
                else
                {
                    throw new Exception("Cylindree hors plage (100-8000)");
                }
                 }
        }


        public int Vitesse
        {
            get { return vitesse; }
            private set { vitesse=(value>0)?value:0; }
        }

        public void Avancer(int accelaration)
        {
            Vitesse += accelaration;
        }

        public void Freiner(int deccelaration)
        {
            Vitesse -= deccelaration;
        }







    }
}
