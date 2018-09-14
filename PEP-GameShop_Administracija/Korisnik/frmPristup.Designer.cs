namespace PEP_GameShop_Administracija.Korisnik
{
    partial class frmPristup
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
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelUloge = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.checkedListBoxUloge = new System.Windows.Forms.CheckedListBox();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(23, 26);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.labelKorisnickoIme.TabIndex = 0;
            this.labelKorisnickoIme.Text = "Korisničko ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(54, 66);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(44, 13);
            this.labelLozinka.TabIndex = 1;
            this.labelLozinka.Text = "Lozinka";
            // 
            // labelUloge
            // 
            this.labelUloge.AutoSize = true;
            this.labelUloge.Location = new System.Drawing.Point(63, 104);
            this.labelUloge.Name = "labelUloge";
            this.labelUloge.Size = new System.Drawing.Size(35, 13);
            this.labelUloge.TabIndex = 2;
            this.labelUloge.Text = "Uloge";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(120, 23);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.ReadOnly = true;
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(171, 20);
            this.textBoxKorisnickoIme.TabIndex = 3;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(120, 63);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(171, 20);
            this.textBoxLozinka.TabIndex = 4;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // checkedListBoxUloge
            // 
            this.checkedListBoxUloge.FormattingEnabled = true;
            this.checkedListBoxUloge.Location = new System.Drawing.Point(120, 89);
            this.checkedListBoxUloge.Name = "checkedListBoxUloge";
            this.checkedListBoxUloge.Size = new System.Drawing.Size(171, 64);
            this.checkedListBoxUloge.TabIndex = 5;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(141, 194);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(75, 31);
            this.buttonSacuvaj.TabIndex = 6;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(120, 159);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(62, 17);
            this.checkBoxStatus.TabIndex = 7;
            this.checkBoxStatus.Text = "Aktivan";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPristup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 242);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.checkedListBoxUloge);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelUloge);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPristup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podatci za pristup sistemu";
            this.Load += new System.EventHandler(this.frmPristup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelUloge;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.CheckedListBox checkedListBoxUloge;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}