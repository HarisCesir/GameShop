namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class FrmDobavljacPretraga
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
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.dataGridViewDobavljaci = new System.Windows.Forms.DataGridView();
            this.DobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(12, 19);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(92, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv dobavljača;";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(110, 16);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(210, 20);
            this.textBoxNaziv.TabIndex = 1;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // dataGridViewDobavljaci
            // 
            this.dataGridViewDobavljaci.AllowUserToAddRows = false;
            this.dataGridViewDobavljaci.AllowUserToDeleteRows = false;
            this.dataGridViewDobavljaci.AllowUserToOrderColumns = true;
            this.dataGridViewDobavljaci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DobavljacID,
            this.Naziv,
            this.Adresa,
            this.Kontakt,
            this.Telefon,
            this.Email});
            this.dataGridViewDobavljaci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDobavljaci.Location = new System.Drawing.Point(0, 59);
            this.dataGridViewDobavljaci.MultiSelect = false;
            this.dataGridViewDobavljaci.Name = "dataGridViewDobavljaci";
            this.dataGridViewDobavljaci.ReadOnly = true;
            this.dataGridViewDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDobavljaci.Size = new System.Drawing.Size(544, 202);
            this.dataGridViewDobavljaci.TabIndex = 2;
            this.dataGridViewDobavljaci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDobavljaci_CellDoubleClick);
            // 
            // DobavljacID
            // 
            this.DobavljacID.DataPropertyName = "DobavljacID";
            this.DobavljacID.HeaderText = "DobavljacID";
            this.DobavljacID.Name = "DobavljacID";
            this.DobavljacID.ReadOnly = true;
            this.DobavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Kontakt
            // 
            this.Kontakt.DataPropertyName = "KontaktOsoba";
            this.Kontakt.HeaderText = "Kontakt";
            this.Kontakt.Name = "Kontakt";
            this.Kontakt.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(390, 7);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(110, 37);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj dobavljaća";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // FrmDobavljacPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewDobavljaci);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDobavljacPretraga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobavljači";
            this.Load += new System.EventHandler(this.FrmDobavljacPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDobavljaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.DataGridView dataGridViewDobavljaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button buttonDodaj;
    }
}