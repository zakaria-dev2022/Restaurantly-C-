namespace OOP_APP
{
    partial class formEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtdn = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpt = new System.Windows.Forms.ComboBox();
            this.Ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.Suprimer = new Guna.UI2.WinForms.Guna2Button();
            this.Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(310, 187);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 26);
            this.txtid.TabIndex = 38;
            this.txtid.Visible = false;
            // 
            // tableau
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tableau.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableau.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableau.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableau.Location = new System.Drawing.Point(28, 438);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Goldenrod;
            this.tableau.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(1060, 222);
            this.tableau.TabIndex = 37;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(39, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(241, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(241, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(39, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nom";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(246, 271);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(161, 26);
            this.txta.TabIndex = 4;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(246, 187);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(161, 26);
            this.txtp.TabIndex = 2;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(44, 187);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(161, 26);
            this.txtn.TabIndex = 1;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.ForeColor = System.Drawing.Color.Goldenrod;
            this.la.Location = new System.Drawing.Point(39, 231);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(48, 26);
            this.la.TabIndex = 39;
            this.la.Text = "Cin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(241, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Poste";
            // 
            // txtcn
            // 
            this.txtcn.Location = new System.Drawing.Point(44, 271);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(161, 26);
            this.txtcn.TabIndex = 3;
            // 
            // txtdn
            // 
            this.txtdn.CalendarForeColor = System.Drawing.Color.White;
            this.txtdn.CalendarMonthBackground = System.Drawing.Color.Black;
            this.txtdn.Location = new System.Drawing.Point(44, 366);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(189, 26);
            this.txtdn.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 102);
            this.panel1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(133, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 56);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gestion Des Employes";
            // 
            // txtpt
            // 
            this.txtpt.FormattingEnabled = true;
            this.txtpt.Items.AddRange(new object[] {
            "Manager",
            "Assistant",
            "Superviseur",
            "Formation Superviseur",
            "Cuisinier",
            "Caissier"});
            this.txtpt.Location = new System.Drawing.Point(246, 364);
            this.txtpt.Name = "txtpt";
            this.txtpt.Size = new System.Drawing.Size(161, 28);
            this.txtpt.TabIndex = 45;
            // 
            // Ajouter
            // 
            this.Ajouter.BorderRadius = 8;
            this.Ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ajouter.FillColor = System.Drawing.Color.Goldenrod;
            this.Ajouter.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ajouter.ForeColor = System.Drawing.Color.Black;
            this.Ajouter.Location = new System.Drawing.Point(702, 180);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(189, 45);
            this.Ajouter.TabIndex = 46;
            this.Ajouter.Text = "Ajouter";
            // 
            // Suprimer
            // 
            this.Suprimer.BorderRadius = 8;
            this.Suprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Suprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Suprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Suprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Suprimer.Enabled = false;
            this.Suprimer.FillColor = System.Drawing.Color.Goldenrod;
            this.Suprimer.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Suprimer.ForeColor = System.Drawing.Color.Black;
            this.Suprimer.Location = new System.Drawing.Point(586, 271);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(189, 45);
            this.Suprimer.TabIndex = 46;
            this.Suprimer.Text = "Suprimer";
            // 
            // Modifier
            // 
            this.Modifier.BorderRadius = 8;
            this.Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Modifier.Enabled = false;
            this.Modifier.FillColor = System.Drawing.Color.Goldenrod;
            this.Modifier.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(836, 271);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(189, 45);
            this.Modifier.TabIndex = 47;
            this.Modifier.Text = "Modifier";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 77);
            this.panel2.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::OOP_APP.Properties.Resources.Design_sans_titre__8_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.txtpt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.la);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formEmployee";
            this.Load += new System.EventHandler(this.formEmployee_Load);
            this.DoubleClick += new System.EventHandler(this.formEmployee_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.DateTimePicker txtdn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtpt;
        private Guna.UI2.WinForms.Guna2Button Ajouter;
        private Guna.UI2.WinForms.Guna2Button Suprimer;
        private Guna.UI2.WinForms.Guna2Button Modifier;
        private System.Windows.Forms.Panel panel2;
    }
}