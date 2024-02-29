using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OOP_APP
{
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void dashbord_Load(object sender, EventArgs e)
        {
          //  Utils.NombreStatictique("reservation",lb_nr);
            Utils.NombreStatictique("client",lb_nc);
            Utils.NombreStatictique("produit",lb_np);
            Utils.chartReservation(chart1);
            Utils.AfficherReservationsPourDemain(lb_nr);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lb_employe_Click(object sender, EventArgs e)
        {
            formEmployee emp= new formEmployee();
            this.Hide();
            emp.Show();
        }

        private void pc_employe_Click(object sender, EventArgs e)
        {
            formEmployee emp = new formEmployee();
            this.Hide();
            emp.Show();
        }

        private void lb_produit_Click(object sender, EventArgs e)
        {
            formProduits produit = new formProduits();
            this.Hide();
            produit.Show();
        }

        private void pc_produit_Click(object sender, EventArgs e)
        {
            formProduits produit = new formProduits();
            this.Hide();
            produit.Show();
        }

        private void lb_reservation_Click(object sender, EventArgs e)
        {
            formReservation reservation = new formReservation();
            this .Hide();
            reservation.Show();
        }

        private void pc_reservation_Click(object sender, EventArgs e)
        {
            formReservation reservation = new formReservation();
            this.Hide();
            reservation.Show();
        }

        private void lb_evenement_Click(object sender, EventArgs e)
        {
            formEvenement evenement = new formEvenement();
            this .Hide();
            evenement.Show();
        }

        private void pc_evenement_Click(object sender, EventArgs e)
        {
            formEvenement evenement = new formEvenement();
            this.Hide();
            evenement.Show();
        }

        private void lb_message_Click(object sender, EventArgs e)
        {
            formMessage message = new formMessage();
            this .Hide();
            message.Show();
        }

        private void pc_message_Click(object sender, EventArgs e)
        {
            formMessage message = new formMessage();
            this.Hide();
            message.Show();
        }

        private void deconncter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Déconnecter ?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
            this.Close();
            login.Show();

        }
        }

        private void parametre_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            this.Hide();
            setting.Show();
        }
    }
}
