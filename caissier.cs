using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    public partial class caissier : Form
    {
        public caissier()
        {
            InitializeComponent();
        }

        private void caissier_Load(object sender, EventArgs e)
        {
           

        }


        void remplir(string ncr)
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees($"SELECT cmd.id as N°Commande ,cmd.qte, c.nom as Nom_client,c.prenom as Prenom_Client,p.libelle, p.prix,tp.type FROM commande cmd\r\nJOIN client c on cmd.client_id=c.id\r\nJOIN produit p on cmd.produit_id=p.id\r\nJOIN type_produits tp on p.id_type_produit=tp.id\r\nWHERE client_id={ncr} and DATE(date_commande) = CURRENT_DATE()");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;
            nouveau();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            caissier caissier = new caissier();
            caissier.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Déconnecter ?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();

            }
        }

        void nouveau()
        {
            txtq.Visible = false;
            label2.Visible = false;
            Modifier.Visible = false;
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            Utils.CloseConnection();
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                txtq.Visible = true;
                label2.Visible = true;
                Modifier.Visible = true;
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°Commande"].Value.ToString();
                txtq.Text = row.Cells["qte"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Restaurantly");
                nouveau();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            int id = int.Parse(txtid.Text);
            int qte = int.Parse(txtq.Text);
            caissierCl.ModifierCommande(qte, id);
            remplir(txtid.Text);
            //Ajouter.Enabled = true;
            Modifier.Enabled = false;
           // Suprimer.Enabled = false;

        }

        private void search_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("Entrer N°client Que Vous Voulez Rechercher", "Gestion Facture");
            remplir(ncr);
        }
    }
}
