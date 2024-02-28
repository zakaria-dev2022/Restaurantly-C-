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
            DataTable dataTable = Utils.ObtenirDonnees("select p.id as N°Produit,p.libelle,p.prix,p.description,t.type,p.image from produit p JOIN type_produits t on p.id_type_produit = t.id");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
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
            Utils.CloseConnection();
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
            Utils.CloseConnection();
            remplir_txttp();
            remplir();
            //panel_type_produit.Visible = false;
            //panel_produit.Visible = true;
        }
        void nouveau()
        {
            Utils.CloseConnection();
            txtl.Text = "";
            txtp.Text = "";
            txtdp.Text = "";
            txttp.Text = "";
            chemin_Img.Text = "";
            img_produit.Image = null;
            txtl.Focus();
            
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

        

        

        private void exit_Click(object sender, EventArgs e)
        {
            dashbord dashbord = new dashbord();
            this.Hide();
            dashbord.Show();
        }

      

        private void Ajouter_Click_2(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            int id_type_produit = TransferTypeInt();
            Produits produit = new Produits(txtl.Text, float.Parse(txtp.Text), txtdp.Text, id_type_produit, chemin_Img.Text);
            Produits.ajouterProduit(produit);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void Modifier_Click_1(object sender, EventArgs e)
        {
            Utils.CloseConnection();
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

        private void Suprimer_Click_1(object sender, EventArgs e)
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

        private void inport_photo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                img_produit.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtl.Text + " De Type " + txttp.Text + typeFile;
                chemin_Img.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\Restaurantly\assets\img\menu\" + chemin);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lb_type.Visible == true)
            {
                lb_type.Visible = false;
                ajouter_type.Visible = false;
               // annuler_type.Visible = false;
                txtntp.Visible = false;
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
                inport_photo.Enabled = true;
                txtl.ReadOnly= true;
                txtp.ReadOnly= true;
                txtdp.ReadOnly= true;
               
            }
            else
            {
            lb_type.Visible = true;
            ajouter_type.Visible = true;
            //annuler_type.Visible = true;
            txtntp.Visible = true;
            Ajouter.Enabled = false;
            Modifier.Enabled=false;
            Suprimer.Enabled = false;
            inport_photo.Enabled = false;
                txtl.ReadOnly = false;
                txtp.ReadOnly = false;
                txtdp.ReadOnly = false;
            }
        }

        private void ajouter_type_Click(object sender, EventArgs e)
        {
            if (txtntp.Text!="")
            {
                Utils.CloseConnection();
                string type = txtntp.Text;
            Produits.ajouterTypeProduit(type);
                txtntp.Text = "";
                txtntp.Focus();
                Utils.CloseConnection();
                // remplir_txttp();
                txttp.Items.Clear();
                remplir_txttp();
            }
            else
            {
                MessageBox.Show("Entrer Votre Nouveaux Type", "Restaurantly");
            }
        }

        private void tableau_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            Utils.CloseConnection();
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°Produit"].Value.ToString();
                txtl.Text = row.Cells["libelle"].Value.ToString();
                txtp.Text = row.Cells["prix"].Value.ToString();
                txtdp.Text = row.Cells["description"].Value.ToString();
               // string id_type_produit = row.Cells["type"].Value.ToString();
                //string type_produit = TransferTypeString(id_type_produit);
                //txttp.Text = type_produit;
                txttp.Text = row.Cells["type"].Value.ToString();
                string cheminimg = row.Cells["image"].Value.ToString();
                img_produit.Load(@"C:\laragon\www\Restaurantly\assets\img\menu\" + cheminimg);
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Restaurantly");
                txtid.Text = "";
                nouveau();
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void img_produit_Click(object sender, EventArgs e)
        {

        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chemin_Img_Click(object sender, EventArgs e)
        {

        }
    }
}
