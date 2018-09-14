namespace PEP_GameShop_Administracija.Zahtjevi
{
    partial class frmPretragaZahtjevaNaziv
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
            this.checkBoxglasovi = new System.Windows.Forms.CheckBox();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.dataGridViewzahtjevi = new System.Windows.Forms.DataGridView();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glasovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewzahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(12, 9);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(55, 6);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(237, 20);
            this.textBoxNaziv.TabIndex = 1;
            // 
            // checkBoxglasovi
            // 
            this.checkBoxglasovi.AutoSize = true;
            this.checkBoxglasovi.Location = new System.Drawing.Point(313, 8);
            this.checkBoxglasovi.Name = "checkBoxglasovi";
            this.checkBoxglasovi.Size = new System.Drawing.Size(116, 17);
            this.checkBoxglasovi.TabIndex = 2;
            this.checkBoxglasovi.Text = "Više od 20 glasova";
            this.checkBoxglasovi.UseVisualStyleBackColor = true;
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(453, 6);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonTrazi.TabIndex = 3;
            this.buttonTrazi.Text = "Traži";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // dataGridViewzahtjevi
            // 
            this.dataGridViewzahtjevi.AllowUserToAddRows = false;
            this.dataGridViewzahtjevi.AllowUserToDeleteRows = false;
            this.dataGridViewzahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewzahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naslov,
            this.Ime,
            this.Glasovi,
            this.Datum});
            this.dataGridViewzahtjevi.Location = new System.Drawing.Point(1, 32);
            this.dataGridViewzahtjevi.Name = "dataGridViewzahtjevi";
            this.dataGridViewzahtjevi.ReadOnly = true;
            this.dataGridViewzahtjevi.Size = new System.Drawing.Size(539, 214);
            this.dataGridViewzahtjevi.TabIndex = 4;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime kupca";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Glasovi
            // 
            this.Glasovi.DataPropertyName = "Glasovi";
            this.Glasovi.HeaderText = "Broj glasova";
            this.Glasovi.Name = "Glasovi";
            this.Glasovi.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum zahtjeva";
            this.Datum.MaxInputLength = 32900;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // frmPretragaZahtjevaNaziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 250);
            this.Controls.Add(this.dataGridViewzahtjevi);
            this.Controls.Add(this.buttonTrazi);
            this.Controls.Add(this.checkBoxglasovi);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.MaximizeBox = false;
            this.Name = "frmPretragaZahtjevaNaziv";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga po nazivu";
            this.Load += new System.EventHandler(this.frmPretragaZahtjevaNaziv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewzahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.CheckBox checkBoxglasovi;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.DataGridView dataGridViewzahtjevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Glasovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}