namespace Gestion.View
{
    partial class frmAppartement
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
            this.btnChoisirA = new System.Windows.Forms.Button();
            this.dgAppartement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCapacite = new System.Windows.Forms.NumericUpDown();
            this.cbProprietaire = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNbrPiece = new System.Windows.Forms.NumericUpDown();
            this.rtbAdresse = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjouterA = new System.Windows.Forms.Button();
            this.btnSupprimerA = new System.Windows.Forms.Button();
            this.btnModifierA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbrPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisirA
            // 
            this.btnChoisirA.Location = new System.Drawing.Point(425, 82);
            this.btnChoisirA.Name = "btnChoisirA";
            this.btnChoisirA.Size = new System.Drawing.Size(75, 23);
            this.btnChoisirA.TabIndex = 45;
            this.btnChoisirA.Text = "Choisir";
            this.btnChoisirA.UseVisualStyleBackColor = true;
            this.btnChoisirA.Click += new System.EventHandler(this.btnChoisirA_Click);
            // 
            // dgAppartement
            // 
            this.dgAppartement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAppartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppartement.Location = new System.Drawing.Point(425, 116);
            this.dgAppartement.Name = "dgAppartement";
            this.dgAppartement.Size = new System.Drawing.Size(799, 460);
            this.dgAppartement.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Propriétaire";
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(41, 279);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(279, 20);
            this.txtSurface.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Surface";
            // 
            // nudCapacite
            // 
            this.nudCapacite.Location = new System.Drawing.Point(41, 433);
            this.nudCapacite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCapacite.Name = "nudCapacite";
            this.nudCapacite.Size = new System.Drawing.Size(279, 20);
            this.nudCapacite.TabIndex = 4;
            // 
            // cbProprietaire
            // 
            this.cbProprietaire.FormattingEnabled = true;
            this.cbProprietaire.Items.AddRange(new object[] {
            "Selectionner"});
            this.cbProprietaire.Location = new System.Drawing.Point(41, 510);
            this.cbProprietaire.Name = "cbProprietaire";
            this.cbProprietaire.Size = new System.Drawing.Size(279, 21);
            this.cbProprietaire.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre de piece";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Capacité";
            // 
            // nudNbrPiece
            // 
            this.nudNbrPiece.Location = new System.Drawing.Point(41, 356);
            this.nudNbrPiece.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNbrPiece.Name = "nudNbrPiece";
            this.nudNbrPiece.Size = new System.Drawing.Size(279, 20);
            this.nudNbrPiece.TabIndex = 3;
            // 
            // rtbAdresse
            // 
            this.rtbAdresse.Location = new System.Drawing.Point(41, 117);
            this.rtbAdresse.Name = "rtbAdresse";
            this.rtbAdresse.Size = new System.Drawing.Size(279, 105);
            this.rtbAdresse.TabIndex = 1;
            this.rtbAdresse.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Adresse";
            // 
            // btnAjouterA
            // 
            this.btnAjouterA.Location = new System.Drawing.Point(43, 553);
            this.btnAjouterA.Name = "btnAjouterA";
            this.btnAjouterA.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterA.TabIndex = 57;
            this.btnAjouterA.Text = "Ajouter";
            this.btnAjouterA.UseVisualStyleBackColor = true;
            this.btnAjouterA.Click += new System.EventHandler(this.btnAjouterA_Click);
            // 
            // btnSupprimerA
            // 
            this.btnSupprimerA.Location = new System.Drawing.Point(247, 555);
            this.btnSupprimerA.Name = "btnSupprimerA";
            this.btnSupprimerA.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerA.TabIndex = 59;
            this.btnSupprimerA.Text = "Supprimer";
            this.btnSupprimerA.UseVisualStyleBackColor = true;
            this.btnSupprimerA.Click += new System.EventHandler(this.btnSupprimerA_Click);
            // 
            // btnModifierA
            // 
            this.btnModifierA.Location = new System.Drawing.Point(145, 555);
            this.btnModifierA.Name = "btnModifierA";
            this.btnModifierA.Size = new System.Drawing.Size(75, 23);
            this.btnModifierA.TabIndex = 58;
            this.btnModifierA.Text = "Modifier";
            this.btnModifierA.UseVisualStyleBackColor = true;
            this.btnModifierA.Click += new System.EventHandler(this.btnModifierA_Click);
            // 
            // frmAppartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 623);
            this.Controls.Add(this.btnAjouterA);
            this.Controls.Add(this.btnSupprimerA);
            this.Controls.Add(this.btnModifierA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbAdresse);
            this.Controls.Add(this.nudNbrPiece);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProprietaire);
            this.Controls.Add(this.nudCapacite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoisirA);
            this.Controls.Add(this.dgAppartement);
            this.Name = "frmAppartement";
            this.Text = "Appartement";
            this.Load += new System.EventHandler(this.frmAppartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbrPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisirA;
        private System.Windows.Forms.DataGridView dgAppartement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCapacite;
        private System.Windows.Forms.ComboBox cbProprietaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNbrPiece;
        private System.Windows.Forms.RichTextBox rtbAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAjouterA;
        private System.Windows.Forms.Button btnSupprimerA;
        private System.Windows.Forms.Button btnModifierA;
    }
}