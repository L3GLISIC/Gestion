namespace Gestion.View
{
    partial class frmProprietaire
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
            this.btnSupprimerP = new System.Windows.Forms.Button();
            this.btnModifierP = new System.Windows.Forms.Button();
            this.btnAjouterP = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRCCM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNinea = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCNI = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgProprietaire = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnChoisirP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProprietaire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimerP
            // 
            this.btnSupprimerP.Location = new System.Drawing.Point(215, 453);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerP.TabIndex = 9;
            this.btnSupprimerP.Text = "Supprimer";
            this.btnSupprimerP.UseVisualStyleBackColor = true;
            this.btnSupprimerP.Click += new System.EventHandler(this.btnSupprimerP_Click);
            // 
            // btnModifierP
            // 
            this.btnModifierP.Location = new System.Drawing.Point(112, 453);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(75, 23);
            this.btnModifierP.TabIndex = 8;
            this.btnModifierP.Text = "Modifier";
            this.btnModifierP.UseVisualStyleBackColor = true;
            this.btnModifierP.Click += new System.EventHandler(this.btnModifierP_Click);
            // 
            // btnAjouterP
            // 
            this.btnAjouterP.Location = new System.Drawing.Point(16, 453);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterP.TabIndex = 7;
            this.btnAjouterP.Text = "Ajouter";
            this.btnAjouterP.UseVisualStyleBackColor = true;
            this.btnAjouterP.Click += new System.EventHandler(this.btnAjouterP_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "RCCM";
            // 
            // txtRCCM
            // 
            this.txtRCCM.Location = new System.Drawing.Point(16, 396);
            this.txtRCCM.Name = "txtRCCM";
            this.txtRCCM.Size = new System.Drawing.Size(278, 20);
            this.txtRCCM.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Ninea";
            // 
            // txtNinea
            // 
            this.txtNinea.Location = new System.Drawing.Point(16, 329);
            this.txtNinea.Name = "txtNinea";
            this.txtNinea.Size = new System.Drawing.Size(278, 20);
            this.txtNinea.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "CNI";
            // 
            // txtCNI
            // 
            this.txtCNI.Location = new System.Drawing.Point(16, 262);
            this.txtCNI.Name = "txtCNI";
            this.txtCNI.Size = new System.Drawing.Size(278, 20);
            this.txtCNI.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Téléphone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(16, 195);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(278, 20);
            this.txtTel.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // dgProprietaire
            // 
            this.dgProprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProprietaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProprietaire.Location = new System.Drawing.Point(427, 61);
            this.dgProprietaire.Name = "dgProprietaire";
            this.dgProprietaire.Size = new System.Drawing.Size(799, 415);
            this.dgProprietaire.TabIndex = 17;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(168, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(129, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(167, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Nom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(16, 61);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(129, 20);
            this.txtPrenom.TabIndex = 0;
            // 
            // btnChoisirP
            // 
            this.btnChoisirP.Location = new System.Drawing.Point(427, 18);
            this.btnChoisirP.Name = "btnChoisirP";
            this.btnChoisirP.Size = new System.Drawing.Size(75, 23);
            this.btnChoisirP.TabIndex = 10;
            this.btnChoisirP.Text = "Choisir";
            this.btnChoisirP.UseVisualStyleBackColor = true;
            this.btnChoisirP.Click += new System.EventHandler(this.btnChoisirP_Click);
            // 
            // frmProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnChoisirP);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterP);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRCCM);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNinea);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCNI);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dgProprietaire);
            this.Name = "frmProprietaire";
            this.Text = "Proprietaire";
            this.Load += new System.EventHandler(this.frmProprietaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProprietaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimerP;
        private System.Windows.Forms.Button btnModifierP;
        private System.Windows.Forms.Button btnAjouterP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRCCM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNinea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCNI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgProprietaire;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnChoisirP;
    }
}