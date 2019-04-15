using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole03
{
    /*
     * Doter le jeu d'une propriété Durée laquelle est définie par une énumération:
     * 
     * Court(double les points de score)
     * Moyen(triple les points de score)
     * Long(quadruple les points de score)
     * Interminable(Augmente les points de score de 5000 points)
     * 
     */
    enum Durees
    {
        Court = 2,
        Moyen = 3,
        Long = 4,
        Interminable = 5000
    }
    class Jeu
    {
        public string Titre { get; set; }
        public Niveaux Niveau { get; set; }
        public Durees Duree { get; set; }
        public List<string> Joueurs { get; set; }

        public Jeu()
        {
            Joueurs = new List<string>();
        }
        public string this[int index]
            {
            get { return Joueurs[index]; }
            set { Joueurs[index] = value; }

            }

        public int Scorer()
        {
            if (Duree==Durees.Interminable)
            {
                return (int)Niveau * 2 + (int)Duree;
            }
            return (int)Niveau * 2 *(int)Duree;
        }

        



        

        

    }
}
