using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    internal class admin
    {
        public string login;
        public string mot_de_passe;
        public string nom_app;
        public string photo;

        public admin(string login, string mot_de_passe, string nom_app, string photo)
        {
            //this.adminsId = adminsId;
            this.login = login;
            this.mot_de_passe = mot_de_passe;
            this.nom_app = nom_app;
            this.photo = photo;

        }

        public static void ModifierAdmin(admin admin)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE admin SET login = @login, mot_de_passe = @mot_de_passe,nom_app = @nom_app, photo = @photo WHERE id = 1";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@login", admin.login);
                        command.Parameters.AddWithValue("@mot_de_passe", admin.mot_de_passe);
                        command.Parameters.AddWithValue("@nom_app", admin.nom_app);
                        command.Parameters.AddWithValue("@photo", admin.photo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Gestion Restaurant");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}", "Gestion Restaurant");
            }
        }


        






















    }
}
