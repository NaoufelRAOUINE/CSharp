using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole07
{
    class Program
    {
        static void Main(string[] args)
        {


            //DemoAdoNet()
            //DemoEntity();
            //DemoLinq();
            DemoTypesAnonymes();


        }

        private static void DemoTypesAnonymes()
        {
            // Initialisation du contexte de données
            NorthContexte contexte = new NorthContexte();

            //Recupération des clients parisiens 
            var enumerationFiltree = contexte.Customers.
                Where(c => c.City == "Paris")
                .Select(cl=>new {cl.CompanyName,cl.City });

            foreach (var c in enumerationFiltree)
            {
                Console.WriteLine("{0}      {1}"
                    , c.CompanyName
                    , c.City
                    );
            }
        }

        private static void DemoLinq()
        {
            //Initialisation du contexte de données
            NorthContexte contexte = new NorthContexte();
            
            //Recupération des clients parisiens via LINQ
            IEnumerable<Customer> clientsParisiens = 
                contexte.Customers.Where(c=>c.City=="Paris");
            //Recupération des clients qui ont plus de 15 commandes
            IEnumerable<Customer> clients =
                contexte.Customers.Where(c => c.Orders.Count > 15);
            //IEnumerable<Customer> clients = from c in contexte.Customers where c.City == "Paris" select c;
            //Parcours et affichage
            Console.WriteLine("Recupération des clients parisiens via LINQ");
            foreach (Customer c in clientsParisiens)
            {
                Console.WriteLine("{0}      {1}"
                    , c.CompanyName
                    , c.City
                    );
            }
            Console.WriteLine("");
            Console.WriteLine("Recupération des clients qui ont plus de 5 commandes");
            foreach (Customer c in clients)
            {
                Console.WriteLine("{0}      {1}"
                    , c.CompanyName
                    , c.City
                    );
            }

        }

        private static void DemoEntity()
        {
            //Initialisation du contexte de données
            NorthContexte contexte = new NorthContexte();

            //Recupération des clients

            IEnumerable<Customer> clients = contexte.Customers;

            //Parcours et affichage

            foreach (Customer c in clients)
            {
                Console.WriteLine("{0}      {1}"
                    , c.CompanyName
                    , c.City
                    );
            }
        }
        private static void DemoAdoNet()
        {
            try
            {
                SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
                cnx.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "select * from Categories";

                SqlDataReader lecteur = cmd.ExecuteReader();

                while (lecteur.Read())
                {
                    Console.WriteLine("{0}                     {1}"
                        , lecteur.GetSqlString(1)
                        , lecteur.GetSqlString(2));
                }
                //foreach (var item in lecteur.GetSqlString(0))
                //{
                //    Console.WriteLine(item);
                //}
            }
            catch (Exception)
            {

                throw new Exception("Connection failed");
            }
        }
    }
}
