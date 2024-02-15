namespace OOP_APP
{
    partial class formTypeProduit
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableau_type = new System.Windows.Forms.DataGridView();
            this.modifier_type = new System.Windows.Forms.Button();
            this.supprimer_type = new System.Windows.Forms.Button();
            this.ajouter_type = new System.Windows.Forms.Button();
            this.txtptp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_type)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(767, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableau_type
            // 
            this.tableau_type.BackgroundColor = System.Drawing.Color.White;
            this.tableau_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau_type.Location = new System.Drawing.Point(76, 229);
            this.tableau_type.Name = "tableau_type";
            this.tableau_type.RowHeadersWidth = 62;
            this.tableau_type.RowTemplate.Height = 28;
            this.tableau_type.Size = new System.Drawing.Size(571, 159);
            this.tableau_type.TabIndex = 12;
            // 
            // modifier_type
            // 
            this.modifier_type.BackColor = System.Drawing.Color.White;
            this.modifier_type.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_type.Location = new System.Drawing.Point(727, 166);
            this.modifier_type.Name = "modifier_type";
            this.modifier_type.Size = new System.Drawing.Size(195, 41);
            this.modifier_type.TabIndex = 11;
            this.modifier_type.Text = "Modifier Type";
            this.modifier_type.UseVisualStyleBackColor = false;
            // 
            // supprimer_type
            // 
            this.supprimer_type.BackColor = System.Drawing.Color.White;
            this.supprimer_type.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_type.Location = new System.Drawing.Point(727, 95);
            this.supprimer_type.Name = "supprimer_type";
            this.supprimer_type.Size = new System.Drawing.Size(195, 41);
            this.supprimer_type.TabIndex = 10;
            this.supprimer_type.Text = "Supprimer Type";
            this.supprimer_type.UseVisualStyleBackColor = false;
            // 
            // ajouter_type
            // 
            this.ajouter_type.BackColor = System.Drawing.Color.White;
            this.ajouter_type.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_type.Location = new System.Drawing.Point(727, 33);
            this.ajouter_type.Name = "ajouter_type";
            this.ajouter_type.Size = new System.Drawing.Size(195, 41);
            this.ajouter_type.TabIndex = 9;
            this.ajouter_type.Text = "Ajouter Type";
            this.ajouter_type.UseVisualStyleBackColor = false;
            // 
            // txtptp
            // 
            this.txtptp.Location = new System.Drawing.Point(189, 111);
            this.txtptp.Name = "txtptp";
            this.txtptp.Size = new System.Drawing.Size(194, 26);
            this.txtptp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type ";
            // 
            // formTypeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableau_type);
            this.Controls.Add(this.modifier_type);
            this.Controls.Add(this.supprimer_type);
            this.Controls.Add(this.ajouter_type);
            this.Controls.Add(this.txtptp);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTypeProduit";
            this.Text = "formTypeProduit";
            this.Load += new System.EventHandler(this.formTypeProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableau_type;
        private System.Windows.Forms.Button modifier_type;
        private System.Windows.Forms.Button supprimer_type;
        private System.Windows.Forms.Button ajouter_type;
        private System.Windows.Forms.TextBox txtptp;
        private System.Windows.Forms.Label label4;
    }
}