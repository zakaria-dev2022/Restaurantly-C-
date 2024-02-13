using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    internal class Produits
    {

        public string libelle ;
        public float prix ;
        public string  description;
        public int id_type_produit ;
        public string image;


        public Produits(string libelle, float prix , string description, int id_type_produit, string image)
        {
            //this.ProduitsId = ProduitsId;
            this.libelle = libelle;
            this.prix  = prix ;
            this.description = description;
            this.id_type_produit = id_type_produit;
            this.image = image;
            
        }

        public static void ajouterProduit(Produits produit)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO produit (libelle,prix,description,id_type_produit,image) VALUES (@libelle, @prix,@description, @id_type_produit,@image)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@libelle", produit.libelle);
                    command.Parameters.AddWithValue("@prix", produit.prix);
                    command.Parameters.AddWithValue("@description", produit.description);
                    command.Parameters.AddWithValue("@id_type_produit", produit.id_type_produit);
                    command.Parameters.AddWithValue("@image", produit.image);
                    

                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success","Gestion Restaurant");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ", "Gestion Restaurant");
            }
        }

        public static void ModifierProduits(Produits produit, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE produit SET libelle = @libelle, prix = @prix,description = @description, id_type_produit = @id_type_produit,image = @image WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@libelle", produit.libelle);
                        command.Parameters.AddWithValue("@prix", produit.prix);
                        command.Parameters.AddWithValue("@description", produit.description);
                        command.Parameters.AddWithValue("@id_type_produit", produit.id_type_produit);
                        command.Parameters.AddWithValue("@image", produit.image);
                        command.Parameters.AddWithValue("@id", id);

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
