using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using pratique;
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
//using static System.Net.WebRequestMethods;

namespace OOP_APP
{
    public partial class formEmployee : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public formEmployee()
        {
            InitializeComponent();
        }

        private void formEmployee_Load(object sender, EventArgs e)
        {
            remplir();
        }

        void nouveau()
        {
            txtn.Text = "";
            txtp.Text = "";
            txtcn.Text = "";
            txtmt.Text = "";
            txtpt.Text = "";
            txtt.Text = "";
            photo.Image= null;
            txtn.Focus();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from employe");
            //DataTable dataTable = Utils.ObtenirDonnees("select nom,prenom,cin,adresse,date_naissance,poste from employe");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se Employe?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("employe", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Restaurantly");
                //Connection.CloseConnection();
                remplir();
                nouveau();
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "" && txtp.Text != "" && txtcn.Text != "" && txtt.Text != "" && txtmt.Text != "" && txtpt.Text != "" && photo.Image != null)
            {
                Employee employee = new Employee(txtn.Text, txtp.Text, txtcn.Text, txtt.Text, txtmt.Text, txtpt.Text, lb_photo.Text);
            int id = int.Parse(txtid.Text);
            Employee.Modifieremployee(employee,id);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txtcn.Text = row.Cells["cin"].Value.ToString();
                txtt.Text = row.Cells["tel"].Value.ToString();
                txtmt.Text = row.Cells["matricule"].Value.ToString();
                txtpt.Text = row.Cells["poste"].Value.ToString();
                lb_photo.Text = row.Cells["photo"].Value.ToString();
                photo.Image = Image.FromFile(@"C:\laragon\www\Restaurantly\assets\img\employer\"+lb_photo.Text);
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Restaurantly");
            }
        }

        private void formEmployee_DoubleClick(object sender, EventArgs e)
        {
            nouveau();
        }

        private void inport_photo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                photo.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtmt.Text + typeFile;
                lb_photo.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\Restaurantly\assets\img\employer\" + chemin);

            }
        }

        private void Ajouter_Click_1(object sender, EventArgs e)
        {
            if (txtn.Text != "" && txtp.Text != "" && txtcn.Text != "" && txtt.Text != "" && txtmt.Text != "" && txtpt.Text != "" && photo.Image != null)
            {
                
            
            Employee employee = new Employee(txtn.Text, txtp.Text, txtcn.Text, txtt.Text, txtmt.Text, txtpt.Text, lb_photo.Text);
            Employee.ajouterEmploye(employee);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            }
            else
            {
                MessageBox.Show("Verifier Votre Donner", "Restaurantly");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
                dashbord dashbord = new dashbord();
                 this.Hide();
                dashbord.Show();

        }

        
        
    }
}
