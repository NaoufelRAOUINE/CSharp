using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO
{
    class Program
    { 
        static void Main(string[] args)
        {
            DemoADOConnection();
            //DemoBoissons();
           
        }

        private static void DemoBoissons()
        {
            

            //Recuperation de la requete
            string strRequete= "SELECT ProductName, UnitPrice FROM Products p JOIN Categories c ON (p.CategoryID = c.CategoryID) " +
                                "WHERE c.CategoryName = 'Beverages'";
            SqlDataReader reader = Requete(strRequete);
            while (reader.Read())
            {

                Console.WriteLine(reader.GetSqlString(0) + "-------------" + reader.GetSqlMoney(1).ToString());

            }
        }

        private static SqlDataReader Requete(string rq)
        {
            //Connexion
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            cnx.Open();

            //Requete aupres de clients
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = rq;
            return cmd.ExecuteReader();
        }

        private static void DemoADOConnection()
        {
          
            String str = "select * from Customers";

            //Recuperation de la requete
            SqlDataReader reader = Requete(str);
            while (reader.Read())
            {

                Console.WriteLine(reader.GetSqlString(0) + "-------------" + reader.GetSqlString(1));

            }
        }
    }
}
