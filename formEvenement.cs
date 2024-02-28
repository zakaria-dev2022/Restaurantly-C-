using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OOP_APP
{
    public partial class formEvenement : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public formEvenement()
        {
            InitializeComponent();
        }

        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from type_reservation");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }
        void nouveau()
        {
            Utils.CloseConnection();
            txtt.Text = "";
            txtp.Text = "";
            txtdp.Text = "";
            chemin_Img.Text = "";
            img_evenement.Image = null;
            txtt.Focus();

        }

            private void exit_Click(object sender, EventArgs e)
        {
            dashbord dashbord = new dashbord();
            this.Hide();
            dashbord.Show();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            Evenement evenement = new Evenement(txtt.Text, float.Parse(txtp.Text), txtdp.Text, chemin_Img.Text);
            int id = int.Parse(txtid.Text);
            Evenement.ModifierEvenements(evenement, id);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            Evenement evenement = new Evenement(txtt.Text, float.Parse(txtp.Text), txtdp.Text, chemin_Img.Text);
            Evenement.ajouterEvenement(evenement);
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
            if (MessageBox.Show("Voulez-vous suprimer Cette Evenement?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("evenement", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Restaurantly");
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
                img_evenement.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtt.Text + typeFile;
                chemin_Img.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\Restaurantly\assets\img\evenement\" + chemin);

            }
        }

        private void formEvenement_Load(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            remplir();
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n=tableau.Rows.Count - 1;
            Utils.CloseConnection();
            if (e.RowIndex >= 0 && e.RowIndex<n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtt.Text = row.Cells["type"].Value.ToString();
                txtp.Text = row.Cells["prix"].Value.ToString();
                txtdp.Text = row.Cells["description"].Value.ToString();
                chemin_Img.Text = row.Cells["image"].Value.ToString();
                img_evenement.Load(@"C:\laragon\www\Restaurantly\assets\img\evenement\" + chemin_Img.Text);
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
    }
}
