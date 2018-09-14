namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class frmDodajDobavljaca
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxKontaktOsoba = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxZiroracun = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kontakt osoba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Žiro račun:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(112, 16);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(184, 20);
            this.textBoxNaziv.TabIndex = 6;
            this.textBoxNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNaziv_Validating);
            // 
            // textBoxKontaktOsoba
            // 
            this.textBoxKontaktOsoba.Location = new System.Drawing.Point(112, 58);
            this.textBoxKontaktOsoba.Name = "textBoxKontaktOsoba";
            this.textBoxKontaktOsoba.Size = new System.Drawing.Size(184, 20);
            this.textBoxKontaktOsoba.TabIndex = 7;
            this.textBoxKontaktOsoba.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKontaktOsoba_Validating);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(112, 97);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(184, 20);
            this.textBoxAdresa.TabIndex = 8;
            this.textBoxAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresa_Validating);
            // 
            // textBoxZiroracun
            // 
            this.textBoxZiroracun.Location = new System.Drawing.Point(112, 198);
            this.textBoxZiroracun.Name = "textBoxZiroracun";
            this.textBoxZiroracun.Size = new System.Drawing.Size(184, 20);
            this.textBoxZiroracun.TabIndex = 9;
            this.textBoxZiroracun.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxZiroracun_Validating);
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(112, 131);
            this.maskedTextBoxTelefon.Mask = "(999) 000-000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBoxTelefon.TabIndex = 10;
            this.maskedTextBoxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxTelefon_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(112, 166);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(184, 20);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(131, 235);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(81, 36);
            this.buttonDodaj.TabIndex = 12;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDodajDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 283);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.maskedTextBoxTelefon);
            this.Controls.Add(this.textBoxZiroracun);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxKontaktOsoba);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodajDobavljaca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje dobavljača";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxKontaktOsoba;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxZiroracun;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}