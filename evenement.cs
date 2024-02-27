using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    internal class Evenement
    {

        public string type;
        public float prix;
        public string description;
        public string image;

        public Evenement(string type, float prix, string description,string image)
        {
            this.type = type;
            this.prix = prix;
            this.description = description;
            this.image = image;

        }


        public static void ajouterEvenement(Evenement evenement)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO type_reservation (type,prix,description,image) VALUES (@type, @prix,@description,@image)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@type", evenement.type);
                    command.Parameters.AddWithValue("@prix", evenement.prix);
                    command.Parameters.AddWithValue("@description", evenement.description);
                    command.Parameters.AddWithValue("@image", evenement.image);


                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success", "Restaurantly");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ", "Restaurantly");
            }
        }


        public static void ModifierEvenements(Evenement evenement, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE type_reservation SET type = @type, prix = @prix,description = @description,image = @image WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@type", evenement.type);
                        command.Parameters.AddWithValue("@prix", evenement.prix);
                        command.Parameters.AddWithValue("@description", evenement.description);
                        command.Parameters.AddWithValue("@image", evenement.image);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Restaurantly");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}", " Restaurantly");
            }
        }







    }
}
