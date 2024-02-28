using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace OOP_APP
{
    public partial class formMessage : Form
    {
        public formMessage()
        {
            InitializeComponent();
        }
        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select m.id AS N°Message,m.type_message,m.commentaire, c.nom,c.prenom ,c.email from message m join client c on m.client_id = c.id \r\n\r\n");
            //DataTable dataTable = Utils.ObtenirDonnees("select nom,prenom,cin,adresse,date_naissance,poste from employe");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void formMessage_Load(object sender, EventArgs e)
        {
            remplir();
        }

        void nouveau()
        {
            txtn.Text = "";
            txtp.Text = "";
            txte.Text = "";
            txttm.Text = "";
            txtm.Text = "";
            txtid.Text = "";
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }
        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°Message"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txte.Text = row.Cells["email"].Value.ToString();
                txttm.Text = row.Cells["type_message"].Value.ToString();
                txtm.Text = row.Cells["commentaire"].Value.ToString();
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Restaurantly");
                txtid.Text = "";
                nouveau();
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (txttm.Text != "" && txtm.Text != "" )
            {
                message message = new message();
                int id = int.Parse(txtid.Text);
                message.ModifierMessage(txttm.Text, txtm.Text, id);
                nouveau();
                remplir();
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se Message?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("message", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Restaurantly");
                //Connection.CloseConnection();
                remplir();
                nouveau();
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
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
