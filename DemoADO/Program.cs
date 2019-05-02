﻿using System;
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
            //DemoADOConnection();
            //DemoBoissons();
            DemoMAJConnecte();
           
        }

        private static void DemoMAJConnecte()
        {
            SqlCommand cmdMAJ = CreationCommand("Update products set unitPrice=99 where ProductID=1");
            int intNbModifs = cmdMAJ.ExecuteNonQuery();
            Console.WriteLine("Il y a eu {0} insertions", intNbModifs);
        }

        private static SqlCommand CreationCommand(string v)
        {
            //Connexion
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            cnx.Open();
            //Requete aupres de clients
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = v;
            return cmd;
        }

        private static void DemoBoissons()
        {
            

            //Recuperation de la requete
            string strRequete= "SELECT ProductName, UnitPrice FROM Products p JOIN Categories c ON (p.CategoryID = c.CategoryID) " +
                                "WHERE c.CategoryName = 'Beverages'";
            SqlDataReader reader = CreationReader(strRequete);
            while (reader.Read())
            {

                Console.WriteLine(reader.GetSqlString(0) + "-------------" + reader.GetSqlMoney(1).ToString());

            }
        }

        private static SqlDataReader CreationReader(string rq)
        {
            
            SqlCommand cmd = CreationCommand(rq);
            return cmd.ExecuteReader();
        }

        private static void DemoADOConnection()
        {
          
            String str = "select * from Customers";

            //Recuperation de la requete
            SqlDataReader reader = CreationReader(str);
            while (reader.Read())
            {

                Console.WriteLine(reader.GetSqlString(0) + "-------------" + reader.GetSqlString(1));

            }
        }
    }
}
