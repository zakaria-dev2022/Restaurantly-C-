namespace OOP_APP
{
    partial class Setting
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
            this.txtna = new System.Windows.Forms.TextBox();
            this.lb_logo = new System.Windows.Forms.Label();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.txtnu = new System.Windows.Forms.TextBox();
            this.inport_photo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oeil_mp = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtna
            // 
            this.txtna.BackColor = System.Drawing.Color.White;
            this.txtna.Location = new System.Drawing.Point(269, 144);
            this.txtna.Multiline = true;
            this.txtna.Name = "txtna";
            this.txtna.Size = new System.Drawing.Size(253, 26);
            this.txtna.TabIndex = 58;
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Location = new System.Drawing.Point(450, 347);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(51, 20);
            this.lb_logo.TabIndex = 56;
            this.lb_logo.Text = "label2";
            this.lb_logo.Visible = false;
            // 
            // txtmp
            // 
            this.txtmp.BackColor = System.Drawing.Color.White;
            this.txtmp.Location = new System.Drawing.Point(269, 260);
            this.txtmp.Name = "txtmp";
            this.txtmp.PasswordChar = '*';
            this.txtmp.Size = new System.Drawing.Size(253, 26);
            this.txtmp.TabIndex = 43;
            // 
            // txtnu
            // 
            this.txtnu.BackColor = System.Drawing.Color.White;
            this.txtnu.Location = new System.Drawing.Point(269, 205);
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(253, 26);
            this.txtnu.TabIndex = 41;
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
            this.inport_photo.Location = new System.Drawing.Point(269, 471);
            this.inport_photo.Name = "inport_photo";
            this.inport_photo.Size = new System.Drawing.Size(189, 45);
            this.inport_photo.TabIndex = 96;
            this.inport_photo.Text = "impote";
            this.inport_photo.Click += new System.EventHandler(this.inport_photo_Click);
            // 
            // btn_save
            // 
            this.btn_save.BorderRadius = 8;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.btn_save.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(662, 523);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(189, 45);
            this.btn_save.TabIndex = 97;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
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
            this.panel1.Size = new System.Drawing.Size(881, 102);
            this.panel1.TabIndex = 98;
            // 
            // exit
            // 
            this.exit.Image = global::OOP_APP.Properties.Resources.cross;
            this.exit.Location = new System.Drawing.Point(801, 12);
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
            this.label5.Size = new System.Drawing.Size(256, 56);
            this.label5.TabIndex = 45;
            this.label5.Text = "Parametre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_APP.Properties.Resources.Design_sans_titre__10_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label10.Location = new System.Drawing.Point(25, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 26);
            this.label10.TabIndex = 99;
            this.label10.Text = "Mot De Passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(25, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nom Utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 26);
            this.label3.TabIndex = 101;
            this.label3.Text = "Nom De Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(25, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 102;
            this.label2.Text = "Photo";
            // 
            // oeil_mp
            // 
            this.oeil_mp.Image = global::OOP_APP.Properties.Resources.eye;
            this.oeil_mp.Location = new System.Drawing.Point(545, 260);
            this.oeil_mp.Name = "oeil_mp";
            this.oeil_mp.Size = new System.Drawing.Size(38, 27);
            this.oeil_mp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oeil_mp.TabIndex = 44;
            this.oeil_mp.TabStop = false;
            this.oeil_mp.Click += new System.EventHandler(this.oeil_mp_Click);
            // 
            // logo
            // 
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Location = new System.Drawing.Point(269, 302);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(253, 153);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 37;
            this.logo.TabStop = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.inport_photo);
            this.Controls.Add(this.txtna);
            this.Controls.Add(this.oeil_mp);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.txtnu);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parametre";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtna;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.PictureBox oeil_mp;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.TextBox txtnu;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2Button inport_photo;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}