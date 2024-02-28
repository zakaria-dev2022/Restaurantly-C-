namespace OOP_APP
{
    partial class formEvenement
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdp = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inport_photo = new Guna.UI2.WinForms.Guna2Button();
            this.Ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.Suprimer = new Guna.UI2.WinForms.Guna2Button();
            this.Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.img_evenement = new System.Windows.Forms.PictureBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.chemin_Img = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_evenement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
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
            this.panel1.TabIndex = 67;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(165, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(546, 56);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gestion Des Evenement";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_APP.Properties.Resources.party__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label11.Location = new System.Drawing.Point(38, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 26);
            this.label11.TabIndex = 100;
            this.label11.Text = "Prix";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label10.Location = new System.Drawing.Point(38, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 26);
            this.label10.TabIndex = 99;
            this.label10.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 98;
            this.label4.Text = "Type";
            // 
            // txtdp
            // 
            this.txtdp.Location = new System.Drawing.Point(43, 323);
            this.txtdp.Multiline = true;
            this.txtdp.Name = "txtdp";
            this.txtdp.Size = new System.Drawing.Size(252, 119);
            this.txtdp.TabIndex = 97;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(43, 242);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(181, 26);
            this.txtp.TabIndex = 95;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(43, 169);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(181, 26);
            this.txtt.TabIndex = 94;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(127, 169);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 26);
            this.txtid.TabIndex = 96;
            this.txtid.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 692);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 59);
            this.panel2.TabIndex = 101;
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
            this.inport_photo.Location = new System.Drawing.Point(555, 368);
            this.inport_photo.Name = "inport_photo";
            this.inport_photo.Size = new System.Drawing.Size(189, 45);
            this.inport_photo.TabIndex = 106;
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
            this.Ajouter.Location = new System.Drawing.Point(829, 225);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(189, 45);
            this.Ajouter.TabIndex = 109;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
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
            this.Suprimer.Location = new System.Drawing.Point(829, 295);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(189, 45);
            this.Suprimer.TabIndex = 108;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
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
            this.Modifier.Location = new System.Drawing.Point(829, 152);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(189, 45);
            this.Modifier.TabIndex = 107;
            this.Modifier.Text = "Modifier";
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label8.Location = new System.Drawing.Point(516, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 105;
            this.label8.Text = "Image";
            // 
            // img_evenement
            // 
            this.img_evenement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_evenement.Location = new System.Drawing.Point(521, 169);
            this.img_evenement.Name = "img_evenement";
            this.img_evenement.Size = new System.Drawing.Size(257, 182);
            this.img_evenement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_evenement.TabIndex = 103;
            this.img_evenement.TabStop = false;
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(163, 481);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(709, 225);
            this.tableau.TabIndex = 102;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            // 
            // chemin_Img
            // 
            this.chemin_Img.AutoSize = true;
            this.chemin_Img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemin_Img.Location = new System.Drawing.Point(559, 285);
            this.chemin_Img.Name = "chemin_Img";
            this.chemin_Img.Size = new System.Drawing.Size(142, 26);
            this.chemin_Img.TabIndex = 104;
            this.chemin_Img.Text = "chemin_Img";
            this.chemin_Img.Visible = false;
            // 
            // formEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 751);
            this.Controls.Add(this.inport_photo);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.img_evenement);
            this.Controls.Add(this.chemin_Img);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdp);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formEvenement";
            this.Load += new System.EventHandler(this.formEvenement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_evenement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdp;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button inport_photo;
        private Guna.UI2.WinForms.Guna2Button Ajouter;
        private Guna.UI2.WinForms.Guna2Button Suprimer;
        private Guna.UI2.WinForms.Guna2Button Modifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox img_evenement;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Label chemin_Img;
    }
}