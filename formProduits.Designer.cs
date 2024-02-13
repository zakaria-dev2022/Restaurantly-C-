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
            this.txtdp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.Button();
            this.Suprimer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.img_produit = new System.Windows.Forms.PictureBox();
            this.upload = new System.Windows.Forms.Button();
            this.txttp = new System.Windows.Forms.ComboBox();
            this.chemin_Img = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdp
            // 
            this.txtdp.Location = new System.Drawing.Point(289, 144);
            this.txtdp.Multiline = true;
            this.txtdp.Name = "txtdp";
            this.txtdp.Size = new System.Drawing.Size(181, 26);
            this.txtdp.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(782, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 57;
            this.label6.Text = "Image";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(76, 142);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(132, 26);
            this.la.TabIndex = 56;
            this.la.Text = "Description";
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(81, 444);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(959, 251);
            this.tableau.TabIndex = 54;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            // 
            // Modifier
            // 
            this.Modifier.Enabled = false;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(820, 356);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(160, 40);
            this.Modifier.TabIndex = 53;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Suprimer
            // 
            this.Suprimer.Enabled = false;
            this.Suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suprimer.Location = new System.Drawing.Point(507, 356);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(160, 40);
            this.Suprimer.TabIndex = 52;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(219, 356);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(160, 40);
            this.Ajouter.TabIndex = 51;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Type Produit ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Libelle";
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(289, 92);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(181, 26);
            this.txtp.TabIndex = 45;
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(289, 47);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(181, 26);
            this.txtl.TabIndex = 44;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(378, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 26);
            this.txtid.TabIndex = 55;
            this.txtid.Visible = false;
            // 
            // img_produit
            // 
            this.img_produit.Location = new System.Drawing.Point(678, 56);
            this.img_produit.Name = "img_produit";
            this.img_produit.Size = new System.Drawing.Size(269, 195);
            this.img_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_produit.TabIndex = 59;
            this.img_produit.TabStop = false;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(732, 277);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(160, 40);
            this.upload.TabIndex = 60;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // txttp
            // 
            this.txttp.FormattingEnabled = true;
            this.txttp.Location = new System.Drawing.Point(289, 199);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(181, 28);
            this.txttp.TabIndex = 61;
            // 
            // chemin_Img
            // 
            this.chemin_Img.AutoSize = true;
            this.chemin_Img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemin_Img.Location = new System.Drawing.Point(739, 284);
            this.chemin_Img.Name = "chemin_Img";
            this.chemin_Img.Size = new System.Drawing.Size(142, 26);
            this.chemin_Img.TabIndex = 62;
            this.chemin_Img.Text = "chemin_Img";
            this.chemin_Img.Visible = false;
            // 
            // formProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 721);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.img_produit);
            this.Controls.Add(this.txtdp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.la);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.chemin_Img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProduits";
            this.Text = "formProduits";
            this.Load += new System.EventHandler(this.formProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox img_produit;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.ComboBox txttp;
        private System.Windows.Forms.Label chemin_Img;
    }
}