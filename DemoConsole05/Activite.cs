using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    //une classe activite abstraite propose: 

    
   
   

     
    //Facturer() qui cumulera aux frais de dossier une somme abstraite
    //Inscriptioncompetetion() qui annoce la date de la prochaine compet
    public abstract class Activite
    { 
        //FacturerFraisDossier() qui annonce des frais de 80 euro
        public int FacturerFraisDossier()
        {
            //Console.WriteLine("Votre Facture est de 80 euro");
            return 80;
        }

        //ObtenirLicense() qui annonce que la license est commandee
        public void ObtenirLicense()
        {
            Console.WriteLine("Votre License est de "+this.GetType().Name+" commandee");
        }

        //Facturer() qui cumulera aux frais de dossier une somme arbitraire
        public abstract int Facturer();

        //Inscriptioncompetetion() qui annonce la date de la prochaine compet
        public abstract void Inscriptioncompetetion();



    }

    //Une classe Danse herite de Activite, coutera 150 euro hors frais et annonce une compet
    class Danse : Activite
    {
        //Facturer() qui cumulera aux frais de dossier une somme arbitraire
        public override int Facturer()
        {
            Console.WriteLine("Votre Facture de Danse est: "+
                ( 150+ this.FacturerFraisDossier()) +" euro"); 
            return ( 150+this.FacturerFraisDossier());
        }

        //Inscriptioncompetetion() qui annonce la date de la prochaine compet
        public override void Inscriptioncompetetion()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine("Une competetion de Danse sera prevue le: "
                +date.AddMonths(2).AddDays(-1).ToString("dd/MM/yyyy")); 
        }
    }
    //prevue 2 mois plus tard
    //Une classe Danse herite de Activite, coutera 175 euro hors frais et annonce une compet
    //prevue 1 mois plus tard
    class Basket : Activite
    {
        //Facturer() qui cumulera aux frais de dossier une somme arbitraire
        public override int Facturer()
        {
            Console.WriteLine("Votre Facture de Basket est: " +
                (this.FacturerFraisDossier()+175) + " euro");
            return (175 + this.FacturerFraisDossier());
        }

        //Inscriptioncompetetion() qui annonce la date de la prochaine compet
        public override void Inscriptioncompetetion()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine("Une competetion de Basket sera prevue le: "
                + date.AddMonths(1).AddDays(-1).ToString("dd/MM/yyyy"));
        }
    }
}
