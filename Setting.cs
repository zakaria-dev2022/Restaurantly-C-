using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_APP
{
    public partial class Setting : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public Setting()
        {
            InitializeComponent();
        }

        void remplir()
        {
            
                   Utils.OpenConnection();

                    string query ="select * from admin where id= 1";
                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtnu.Text = reader[1].ToString();
                        txtmp.Text = reader[2].ToString();
                        txtna.Text= reader[3].ToString();
                        lb_logo.Text = reader[4].ToString();
                    }
                    Utils.CloseConnection();
                    //reader.Close();
                   
                    logo.Load(@"C:\laragon\www\Restaurantly\assets\img\logo\" + lb_logo.Text);
                }
                
            
               // Console.WriteLine($"Erreur lors de la recuperation de la colonne : {ex.Message}");
                //MessageBox.Show($"Erreur lors de la recuperon de la colonne : {ex.Message}");
            
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            remplir();
        }

       
        private void btn_ann_para_Click(object sender, EventArgs e)
        {
          
        }

        private void oeil_mp_Click(object sender, EventArgs e)
        {
            if (txtmp.PasswordChar == '*')
            {
                txtmp.PasswordChar = '\0';
            }
            else
            {
                txtmp.PasswordChar = '*';
            }
        }

       /* private void btn_modifier_info_Click(object sender, EventArgs e)
        {
            if (txtnu_modifier.Text != null && txtmp_modifier.Text != null && txtcmp_modifier.Text != null)
            {
                if (txtmp_modifier.Text == txtcmp_modifier.Text)
                {
                    if (MessageBox.Show("Voulez-Vous Modifier Vos Donner?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Utils.CloseConnection();
                        pasword pasword = new pasword(txtnu_modifier.Text, txtmp_modifier.Text);
                        pasword.Modifierpasword(pasword);
                        remplir();
                        enable_info();
                        MessageBox.Show("Modification Effectuer", "Restaurantly");
                    }
                }
                else
                {
                    lb_msg.Text = "Votre Mot De Passe Incorrect!!";
                    lb_msg.Visible = true;
                    txtmp_modifier.Text = "";
                    txtcmp_modifier.Text = "";
                    txtmp_modifier.Focus();
                }

            }
            else
            {
                MessageBox.Show("Tu Dois Remplir Votre Donner!!", "Gestion Location Voiture");
                txtnu_modifier.Text = "";
                txtmp_modifier.Text = "";
                txtcmp_modifier.Text = "";
                txtnu_modifier.Focus();
            }
        }*/

        private void inport_photo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                logo.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + " Logo " + typeFile;
                lb_logo.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\Restaurantly\assets\img\logo\" + chemin);

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Sortir??", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dashbord dashboard = new dashbord();
                dashboard.Show();
                this.Hide();
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            admin admin = new admin(txtnu.Text, txtmp.Text, txtna.Text, lb_logo.Text);
            admin.ModifierAdmin(admin);
            remplir();
        }
    }
}
