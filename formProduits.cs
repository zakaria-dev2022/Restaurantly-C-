using Google.Protobuf.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    public partial class formProduits : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public formProduits()
        {
            InitializeComponent();
        }
        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }
        
        public int TransferTypeInt()
        {
            Utils.CloseConnection();
            DataTable dataTable = Utils.ObtenirDonnees("select id from type_produits where type = '" + txttp.Text + "'");

            if (dataTable.Rows.Count > 0)
            {
                // Si des données ont été retournées par la requête
                int id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                Console.WriteLine("ID récupéré : " + id);
                MessageBox.Show("ID récupéré : " + id);
                 //txttp.Text = id.ToString();
                return id;
                // Vous pouvez maintenant utiliser la variable "id" comme vous le souhaitez
            }

            // S'il n'y a aucune donnée retournée, vous pouvez retourner une valeur par défaut ou jeter une exception, selon votre cas.
            throw new Exception("Aucune donnée trouvée pour le type de produit : " + txttp.Text);
        }
        
        public void remplir_txttp()
        {
            //remplir txttp depuis la base de donner
            DataTable dataTable = Utils.ObtenirDonnees("select * from type_produits");
            foreach (DataRow row in dataTable.Rows)
            {
                string texte = row["type"].ToString(); // Remplacez "colonne_texte" par le nom de votre colonne
                //txttp.Items.AppendText(texte + Environment.NewLine);
                txttp.Items.Add(texte);
            }


        }

        private void formProduits_Load(object sender, EventArgs e)
        {
            remplir_txttp();
            remplir();
            //panel_type_produit.Visible = false;
            panel_produit.Visible = true;
        }
        void nouveau()
        {
            txtl.Text = "";
            txtp.Text = "";
            txtdp.Text = "";
            txttp.Text = "";
            chemin_Img.Text = "";
            img_produit.Image = null;
            txtl.Focus();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            int id_type_produit = TransferTypeInt();
            
             Produits produit = new Produits(txtl.Text,float.Parse(txtp.Text), txtdp.Text, id_type_produit, chemin_Img.Text);
              Produits.ajouterProduit(produit);
              nouveau();
              //Connection.CloseConnection();
              remplir();
              Ajouter.Enabled = true;
              Modifier.Enabled = false;
              Suprimer.Enabled = false;

        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer Ce Produit?", "Gestion Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("produit", txtid.Text);
                MessageBox.Show("Supression Avec Success");
                remplir();
                nouveau();
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id_type_produit = TransferTypeInt();
            Produits produit = new Produits(txtl.Text, float.Parse(txtp.Text), txtdp.Text, id_type_produit, chemin_Img.Text);
            int id = int.Parse(txtid.Text);
            Produits.ModifierProduits(produit, id);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                img_produit.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtl.Text + " De Type "+ txttp.Text + typeFile;
                chemin_Img.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\OOP APP\Site\img\" + chemin);

            }
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtl.Text = row.Cells["libelle"].Value.ToString();
                txtp.Text = row.Cells["prix"].Value.ToString();
                txtdp.Text = row.Cells["description"].Value.ToString();
                string id_type_produit = row.Cells["id_type_produit"].Value.ToString();
               string type_produit=TransferTypeString(id_type_produit);
                txttp.Text = type_produit;
                chemin_Img.Text = row.Cells["image"].Value.ToString();
                img_produit.Load(@"C:\laragon\www\OOP APP\image\" + chemin_Img.Text);
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
        }
        public string TransferTypeString(string id_type_produit)
        {

            Utils.CloseConnection();
            DataTable dataTable = Utils.ObtenirDonnees("select type from type_produits where id = '" + id_type_produit + "'");

            if (dataTable.Rows.Count > 0)
            {
                // Si des données ont été retournées par la requête
                string type = dataTable.Rows[0]["type"].ToString();
                Console.WriteLine("ID récupéré : " + type);
                MessageBox.Show("ID récupéré : " + type);
                //txttp.Text = id.ToString();
                return type;
                // Vous pouvez maintenant utiliser la variable "id" comme vous le souhaitez
            }

            // S'il n'y a aucune donnée retournée, vous pouvez retourner une valeur par défaut ou jeter une exception, selon votre cas.
            throw new Exception("Aucune donnée trouvée pour le type de produit : " + txttp.Text);
        }

        private void btn_ajouter_type_produit_Click(object sender, EventArgs e)
        {
            formTypeProduit formtp = new formTypeProduit();
            formtp.Show();
            this.Hide();
           
        }

        private void panel_produit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
