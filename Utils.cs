using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace OOP_APP
{
    internal class Utils
    {
       public static MySqlConnection cnx = new MySqlConnection("server=localhost;database=restaurant;uid=root;password=");
        public static DataTable dataTable = new DataTable();



        public static void OpenConnection()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Closed)
                {
                    cnx.Open();
                    Console.WriteLine("Connexion à la base de données ouverte avec succès.");
                    MessageBox.Show("Connexion à la base de données ouverte avec succès.","Gestion Restaurant");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                MessageBox.Show("Erreur lors de l'ouverture de la connexion : " + ex.Message, "Gestion Restaurant");
            }
        }

        // Méthode pour fermer la connexion
        public static void CloseConnection()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    cnx.Close();
                    Console.WriteLine("Connexion à la base de données fermée avec succès.");
                     MessageBox.Show("Connexion à la base de données fermer avec succès.", "Gestion Restaurant");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
                MessageBox.Show("Connexion à la base de données fermer avec succès.", "Gestion Restaurant");
            }
        }


       public static void SuprimerDonner(string table, string id)
        {
            try
            {
                {
                    cnx.Open();

                    string query = $"delete from {table} where id=  {id}";

                    //using (SqlCommand command = new SqlCommand(query,cnx))
                      MySqlCommand command = new MySqlCommand(query, cnx);
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"La colonne {id} a été supprimée de la table {table} avec succès.");
                        MessageBox.Show($"La colonne {id} a été supprimée de la table {table} avec succès.", "Gestion Restaurant");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la suppression de la colonne : {ex.Message}");
                MessageBox.Show($"Erreur lors de la suppression de la colonne : {ex.Message}");
            }
        }



        public static DataTable ObtenirDonnees(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, cnx);

                {
                    cnx.Open();
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des données : {ex.Message}");
                MessageBox.Show($"Erreur lors de la récupération des données .{ex.Message}", "Gestion Restaurant");
            }

            return dataTable;
        }




















    }
}














namespace pratique
{
    internal class Connection
    {
       
       









    }
}
