using MySqlX.XDevAPI;
using pratique;
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
    public partial class formEmployee : Form
    {
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
            txta.Text = "";
            txtpt.Text = "";
            txtn.Focus();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from employee");
            //DataTable dataTable = Utils.ObtenirDonnees("select nom,prenom,cin,adresse,date_naissance,post from employee");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtn.Text, txtp.Text, txtcn.Text, txta.Text, Convert.ToDateTime(txtdn.Text), txtpt.Text);
            Employee.ajouterEmploye(employee);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se Employee?", "Gestion Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("employee", txtid.Text);
                MessageBox.Show("Supression Avec Success");
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
            
            Employee employee = new Employee(txtn.Text, txtp.Text, txtcn.Text, txta.Text, Convert.ToDateTime(txtdn.Text), txtpt.Text);
            int id = int.Parse(txtid.Text);
            Employee.Modifieremployee(employee,id);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txtcn.Text = row.Cells["cin"].Value.ToString();
                txta.Text = row.Cells["adresse"].Value.ToString();
                txtdn.Text = row.Cells["date_naissance"].Value.ToString();
                txtpt.Text = row.Cells["post"].Value.ToString();
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
        }

        private void formEmployee_DoubleClick(object sender, EventArgs e)
        {
            nouveau();
        }
    }
}
