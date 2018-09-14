namespace PEP_GameShop_Administracija.Korisnik
{
    partial class frmKorisnikNovi
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
            this.checkedListBoxUloge = new System.Windows.Forms.CheckedListBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelUloge = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.pristupPanel = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pristupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxUloge
            // 
            this.checkedListBoxUloge.FormattingEnabled = true;
            this.checkedListBoxUloge.Location = new System.Drawing.Point(89, 76);
            this.checkedListBoxUloge.Name = "checkedListBoxUloge";
            this.checkedListBoxUloge.Size = new System.Drawing.Size(186, 49);
            this.checkedListBoxUloge.TabIndex = 7;
            this.checkedListBoxUloge.Validating += new System.ComponentModel.CancelEventHandler(this.checkedListBoxUloge_Validating);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(50, 28);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(35, 58);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 1;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(47, 80);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(39, 112);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelTelefon.TabIndex = 3;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(83, 28);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(189, 20);
            this.textBoxIme.TabIndex = 1;
            this.textBoxIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIme_Validating);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(83, 54);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(189, 20);
            this.textBoxPrezime.TabIndex = 2;
            this.textBoxPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrezime_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(83, 77);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(189, 20);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(83, 109);
            this.maskedTextBoxTelefon.Mask = "(999) 000-000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(189, 20);
            this.maskedTextBoxTelefon.TabIndex = 4;
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(5, 20);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.labelKorisnickoIme.TabIndex = 8;
            this.labelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(36, 53);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(47, 13);
            this.labelLozinka.TabIndex = 9;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // labelUloge
            // 
            this.labelUloge.AutoSize = true;
            this.labelUloge.Location = new System.Drawing.Point(48, 88);
            this.labelUloge.Name = "labelUloge";
            this.labelUloge.Size = new System.Drawing.Size(35, 13);
            this.labelUloge.TabIndex = 10;
            this.labelUloge.Text = "Uloge";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(89, 17);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(186, 20);
            this.textBoxKorisnickoIme.TabIndex = 5;
            this.textBoxKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKorisnickoIme_Validating);
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(89, 50);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(186, 20);
            this.textBoxLozinka.TabIndex = 6;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            this.textBoxLozinka.TextChanged += new System.EventHandler(this.textBoxLozinka_TextChanged);
            this.textBoxLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLozinka_Validating);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(181, 162);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 32);
            this.buttonOdustani.TabIndex = 8;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(329, 162);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(75, 32);
            this.buttonSacuvaj.TabIndex = 9;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // pristupPanel
            // 
            this.pristupPanel.Controls.Add(this.checkedListBoxUloge);
            this.pristupPanel.Controls.Add(this.labelKorisnickoIme);
            this.pristupPanel.Controls.Add(this.labelLozinka);
            this.pristupPanel.Controls.Add(this.textBoxLozinka);
            this.pristupPanel.Controls.Add(this.labelUloge);
            this.pristupPanel.Controls.Add(this.textBoxKorisnickoIme);
            this.pristupPanel.Location = new System.Drawing.Point(329, 12);
            this.pristupPanel.Name = "pristupPanel";
            this.pristupPanel.Size = new System.Drawing.Size(296, 144);
            this.pristupPanel.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKorisnikNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 212);
            this.Controls.Add(this.pristupPanel);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.maskedTextBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKorisnikNovi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Korisnik";
            this.Load += new System.EventHandler(this.frmKorisnikNovi_Load);
            this.pristupPanel.ResumeLayout(false);
            this.pristupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxUloge;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelUloge;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Panel pristupPanel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}