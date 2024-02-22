using MySql.Data.MySqlClient;
using pratique;
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





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
