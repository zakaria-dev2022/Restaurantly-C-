using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void connecter_Click(object sender, EventArgs e)
        {
             if (txtlg.Text != "" && txtmp.Text != "")
             {
                 string connectionString = "server=localhost;user=root;database=restaurant_db;password=";

                 string query = "SELECT * FROM admin WHERE login = @Username AND mot_de_passe = @Password";

                 using (MySqlConnection connection = new MySqlConnection(connectionString))
                 {
                     MySqlCommand cmd = new MySqlCommand(query, connection);
                     cmd.Parameters.AddWithValue("@Username", txtlg.Text);
                     cmd.Parameters.AddWithValue("@Password", txtmp.Text);

                     try
                     {
                         connection.Open();
                         using (MySqlDataReader rd = cmd.ExecuteReader())
                         {
                             if (rd.Read()) // Vérifie si une ligne correspondante a été trouvée
                             {
                                 // Les informations de connexion sont correctes
                                 this.Hide();
                                 dashbord dashbord= new dashbord();
                                 dashbord.Show();
                                 return;
                             }
                         }


                         // Aucune correspondance trouvée dans la base de données
                         MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         txtmp.Text = "";
                         txtmp.Focus();
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Veuillez saisir le nom d'utilisateur et le mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }


           /* if (txtlg.Text != "" && txtmp.Text != "")
            {
                try
                {
                    // Définir la chaîne de connexion à la base de données à partir de la classe Utils
                    string connectionString = "server=localhost;user=root;database=restaurant_db;password=";

                    // Requête SQL pour vérifier le login et le mot de passe dans la table admin
                    string queryAdmin = "SELECT * FROM admin WHERE login = @Username AND mot_de_passe = @Password";

                    // Requête SQL pour vérifier le login et le mot de passe dans la table employe
                    string queryEmployee = "SELECT * FROM employe WHERE login = @Username AND mot_de_passe = @Password";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        // Essayer d'abord de trouver l'utilisateur dans la table admin
                        if (FindUser(connection, queryAdmin))
                        {
                            // Utilisateur trouvé dans la table admin, rediriger vers la page dashboard
                            this.Hide();
                            dashbord dashboard = new dashbord();
                            dashboard.Show();
                            Utils.CloseConnection();
                            return;
                        }
                        // Si l'utilisateur n'est pas trouvé dans la table admin, essayer de le trouver dans la table employe
                        else if (FindUser(connection, queryEmployee))
                        {
                            // Utilisateur trouvé dans la table employe, rediriger vers la page caissier
                            this.Hide();
                            caissier caissier = new caissier();
                            caissier.Show();
                            Utils.CloseConnection();
                            return;
                        }
                        else
                        {
                            // Aucune correspondance trouvée dans la base de données
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmp.Text = "";
                            txtmp.Focus();
                            Utils.CloseConnection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir le nom d'utilisateur et le mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        // Méthode pour trouver l'utilisateur dans la base de données en utilisant la requête spécifiée
         bool FindUser(MySqlConnection connection, string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", txtlg.Text);
            cmd.Parameters.AddWithValue("@Password", txtmp.Text);

            connection.Open();
            using (MySqlDataReader rd = cmd.ExecuteReader())
            {
                if (rd.Read()) // Vérifie si une ligne correspondante a été trouvée
                {
                    return true;
                }
            }
            return false;
        }
           */









    }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
