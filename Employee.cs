using MySql.Data.MySqlClient;
using pratique;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    internal class Employee
    {
        // public int employeeId;
        public string nom;
        public string prenom;
        public string cin;
        public string adresse;
        public DateTime date_naissance;
        public string post;


        public Employee(string nom, string prenom, string cin, string adresse, DateTime date_naissance, string post)
        {
            //this.employeeId = employeeId;
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.adresse = adresse;
            this.date_naissance = date_naissance;
            this.post = post;
        }

        public static void ajouterEmploye(Employee employee)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO employee (nom, prenom,cin, adresse,date_naissance, post) VALUES (@Nom, @Prenom,@cin, @Adresse,@date_naissance, @post)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@Nom", employee.nom);
                    command.Parameters.AddWithValue("@Prenom", employee.prenom);
                    command.Parameters.AddWithValue("@cin", employee.cin);
                    command.Parameters.AddWithValue("@Adresse", employee.adresse);
                    command.Parameters.AddWithValue("@date_naissance", employee.date_naissance);
                    command.Parameters.AddWithValue("@post", employee.post);

                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void Modifieremployee(Employee employee, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE employee SET nom = @Nom, prenom = @Prenom,cin = @cin, adresse = @Adresse,date_naissance = @date_naissance, post = @post WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@Nom", employee.nom);
                        command.Parameters.AddWithValue("@Prenom", employee.prenom);
                        command.Parameters.AddWithValue("@cin", employee.cin);
                        command.Parameters.AddWithValue("@Adresse", employee.adresse);
                        command.Parameters.AddWithValue("@date_naissance", employee.date_naissance);
                        command.Parameters.AddWithValue("@post", employee.post);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}");
            }
        }


    }
}





















