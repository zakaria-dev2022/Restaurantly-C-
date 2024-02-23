namespace OOP_APP
{
    partial class formProduits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.ComboBox();
            this.txtdp = new System.Windows.Forms.TextBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.chemin_Img = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.img_produit = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inport_photo = new Guna.UI2.WinForms.Guna2Button();
            this.Ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.Suprimer = new Guna.UI2.WinForms.Guna2Button();
            this.Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.txtntp = new System.Windows.Forms.TextBox();
            this.ajouter_type = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_produit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 102);
            this.panel1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(165, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(485, 56);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gestion Des Produits";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label11.Location = new System.Drawing.Point(48, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 26);
            this.label11.TabIndex = 93;
            this.label11.Text = "Prix";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label10.Location = new System.Drawing.Point(48, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 26);
            this.label10.TabIndex = 92;
            this.label10.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label9.Location = new System.Drawing.Point(299, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 26);
            this.label9.TabIndex = 91;
            this.label9.Text = "Type Produit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label8.Location = new System.Drawing.Point(565, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 90;
            this.label8.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(48, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 89;
            this.label4.Text = "Libelle";
            // 
            // txttp
            // 
            this.txttp.FormattingEnabled = true;
            this.txttp.Location = new System.Drawing.Point(304, 172);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(181, 28);
            this.txttp.TabIndex = 86;
            // 
            // txtdp
            // 
            this.txtdp.Location = new System.Drawing.Point(53, 328);
            this.txtdp.Multiline = true;
            this.txtdp.Name = "txtdp";
            this.txtdp.Size = new System.Drawing.Size(252, 77);
            this.txtdp.TabIndex = 83;
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(115, 452);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(895, 225);
            this.tableau.TabIndex = 80;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick_1);
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(53, 247);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(181, 26);
            this.txtp.TabIndex = 73;
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(53, 174);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(181, 26);
            this.txtl.TabIndex = 72;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(137, 174);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 26);
            this.txtid.TabIndex = 81;
            this.txtid.Visible = false;
            // 
            // chemin_Img
            // 
            this.chemin_Img.AutoSize = true;
            this.chemin_Img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemin_Img.Location = new System.Drawing.Point(608, 288);
            this.chemin_Img.Name = "chemin_Img";
            this.chemin_Img.Size = new System.Drawing.Size(142, 26);
            this.chemin_Img.TabIndex = 87;
            this.chemin_Img.Text = "chemin_Img";
            this.chemin_Img.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_APP.Properties.Resources.plus;
            this.pictureBox2.Location = new System.Drawing.Point(497, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // img_produit
            // 
            this.img_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_produit.Location = new System.Drawing.Point(570, 172);
            this.img_produit.Name = "img_produit";
            this.img_produit.Size = new System.Drawing.Size(257, 182);
            this.img_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_produit.TabIndex = 84;
            this.img_produit.TabStop = false;
            // 
            // exit
            // 
            this.exit.Image = global::OOP_APP.Properties.Resources.cross;
            this.exit.Location = new System.Drawing.Point(1027, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(61, 70);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 46;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_APP.Properties.Resources.product;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inport_photo
            // 
            this.inport_photo.BorderRadius = 8;
            this.inport_photo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inport_photo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inport_photo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inport_photo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inport_photo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.inport_photo.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.inport_photo.ForeColor = System.Drawing.Color.Black;
            this.inport_photo.Location = new System.Drawing.Point(604, 371);
            this.inport_photo.Name = "inport_photo";
            this.inport_photo.Size = new System.Drawing.Size(189, 45);
            this.inport_photo.TabIndex = 95;
            this.inport_photo.Text = "impote";
            this.inport_photo.Click += new System.EventHandler(this.inport_photo_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BorderRadius = 8;
            this.Ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.Ajouter.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ajouter.ForeColor = System.Drawing.Color.Black;
            this.Ajouter.Location = new System.Drawing.Point(878, 228);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(189, 45);
            this.Ajouter.TabIndex = 98;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click_2);
            // 
            // Suprimer
            // 
            this.Suprimer.BorderRadius = 8;
            this.Suprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Suprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Suprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Suprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Suprimer.Enabled = false;
            this.Suprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.Suprimer.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Suprimer.ForeColor = System.Drawing.Color.Black;
            this.Suprimer.Location = new System.Drawing.Point(878, 298);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(189, 45);
            this.Suprimer.TabIndex = 97;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click_1);
            // 
            // Modifier
            // 
            this.Modifier.BorderRadius = 8;
            this.Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Modifier.Enabled = false;
            this.Modifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.Modifier.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(878, 155);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(189, 45);
            this.Modifier.TabIndex = 96;
            this.Modifier.Text = "Modifier";
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 692);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 59);
            this.panel2.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(868, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 51);
            this.label1.TabIndex = 46;
            this.label1.Text = "Restaurantly";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.lb_type.Location = new System.Drawing.Point(299, 216);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(146, 26);
            this.lb_type.TabIndex = 101;
            this.lb_type.Text = "Type Produit";
            this.lb_type.Visible = false;
            // 
            // txtntp
            // 
            this.txtntp.Location = new System.Drawing.Point(304, 247);
            this.txtntp.Name = "txtntp";
            this.txtntp.Size = new System.Drawing.Size(181, 26);
            this.txtntp.TabIndex = 100;
            this.txtntp.Visible = false;
            // 
            // ajouter_type
            // 
            this.ajouter_type.BorderRadius = 8;
            this.ajouter_type.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouter_type.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouter_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouter_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouter_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.ajouter_type.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ajouter_type.ForeColor = System.Drawing.Color.Black;
            this.ajouter_type.Location = new System.Drawing.Point(383, 298);
            this.ajouter_type.Name = "ajouter_type";
            this.ajouter_type.Size = new System.Drawing.Size(102, 45);
            this.ajouter_type.TabIndex = 103;
            this.ajouter_type.Text = "Save";
            this.ajouter_type.Visible = false;
            this.ajouter_type.Click += new System.EventHandler(this.ajouter_type_Click);
            // 
            // formProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 751);
            this.Controls.Add(this.ajouter_type);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.txtntp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inport_photo);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.img_produit);
            this.Controls.Add(this.txtdp);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.chemin_Img);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProduits";
            this.Load += new System.EventHandler(this.formProduits_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_produit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txttp;
        private System.Windows.Forms.PictureBox img_produit;
        private System.Windows.Forms.TextBox txtdp;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label chemin_Img;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button inport_photo;
        private Guna.UI2.WinForms.Guna2Button Ajouter;
        private Guna.UI2.WinForms.Guna2Button Suprimer;
        private Guna.UI2.WinForms.Guna2Button Modifier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TextBox txtntp;
        private Guna.UI2.WinForms.Guna2Button ajouter_type;
    }
}