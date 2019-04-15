using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
   public class Pret
    {
        private int _duree;
        private double _taux;
        private double _montant;


        public Pret(double tx, int duree, double montant)
        {
            Duree = duree;
            Taux = tx;
            Montant = montant;
        }

        public double Montant
        {
            get { return _montant; }
            set
            {
                if (value<0)
                {
                    throw new PretException { Montant=value,Duree=Duree,Taux=Taux,Source="Pret Bancaire"};
                }
                _montant = value;
            }
        }


        public double Taux
        {
            get { return _taux; }
            set
            {
                if (value<0||value>20)
                {
                    throw new PretException { Montant = Montant, Duree = Duree, Taux = value, Source = "Taux inexploitable" };
                }
                _taux = value;
            }
        }


        public int Duree
        {
            get { return _duree; }
            set
            {
                if (value<0)
                {
                    throw new PretException { Montant = Montant, Duree = value, Taux = Taux, Source = "La duree doit etre positive" };
                    
                }
                _duree = value;
            }
        }

        public double CalculMensualite()
        {
            return -Financial.Pmt(Taux/1200, Duree*12, Montant);
        }

    }
}
