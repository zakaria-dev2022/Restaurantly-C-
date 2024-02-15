namespace OOP_APP
{
    partial class Login
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
            this.lb_logo = new System.Windows.Forms.Label();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connecter = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Location = new System.Drawing.Point(300, 187);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(51, 20);
            this.lb_logo.TabIndex = 16;
            this.lb_logo.Text = "label5";
            this.lb_logo.Visible = false;
            // 
            // txtmp
            // 
            this.txtmp.Location = new System.Drawing.Point(189, 407);
            this.txtmp.Name = "txtmp";
            this.txtmp.PasswordChar = '*';
            this.txtmp.Size = new System.Drawing.Size(349, 26);
            this.txtmp.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(206, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mot De Passe";
            // 
            // txtlg
            // 
            this.txtlg.Location = new System.Drawing.Point(189, 302);
            this.txtlg.Name = "txtlg";
            this.txtlg.Size = new System.Drawing.Size(349, 26);
            this.txtlg.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(206, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login";
            // 
            // connecter
            // 
            this.connecter.BorderRadius = 8;
            this.connecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.connecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.connecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.connecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.connecter.FillColor = System.Drawing.Color.Goldenrod;
            this.connecter.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.connecter.ForeColor = System.Drawing.Color.Black;
            this.connecter.Location = new System.Drawing.Point(279, 479);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(189, 45);
            this.connecter.TabIndex = 17;
            this.connecter.Text = "Se Connecter";
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // logo
            // 
            this.logo.Image = global::OOP_APP.Properties.Resources.Saveurs;
            this.logo.Location = new System.Drawing.Point(212, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(344, 208);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 556);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lb_logo);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2Button connecter;
    }
}