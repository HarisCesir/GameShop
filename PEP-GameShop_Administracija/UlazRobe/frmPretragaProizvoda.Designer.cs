namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class frmPretragaProizvoda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.dataGridViewPretraga = new System.Windows.Forms.DataGridView();
            this.Šifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(60, 19);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(154, 20);
            this.textBoxSifra.TabIndex = 2;
            this.textBoxSifra.TextChanged += new System.EventHandler(this.textBoxSifra_TextChanged);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(325, 16);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(171, 20);
            this.textBoxNaziv.TabIndex = 3;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // dataGridViewPretraga
            // 
            this.dataGridViewPretraga.AllowUserToAddRows = false;
            this.dataGridViewPretraga.AllowUserToDeleteRows = false;
            this.dataGridViewPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Šifra,
            this.Naziv,
            this.Cijena,
            this.DatumIzdavanja,
            this.Status});
            this.dataGridViewPretraga.Location = new System.Drawing.Point(1, 54);
            this.dataGridViewPretraga.Name = "dataGridViewPretraga";
            this.dataGridViewPretraga.ReadOnly = true;
            this.dataGridViewPretraga.Size = new System.Drawing.Size(525, 175);
            this.dataGridViewPretraga.TabIndex = 4;
            // 
            // Šifra
            // 
            this.Šifra.DataPropertyName = "Šifra";
            this.Šifra.HeaderText = "Šifra";
            this.Šifra.Name = "Šifra";
            this.Šifra.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FalseValue = "0";
            this.Status.HeaderText = "Aktivan";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.TrueValue = "1";
            // 
            // frmPretragaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 233);
            this.Controls.Add(this.dataGridViewPretraga);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPretragaProizvoda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga proizvoda";
            this.Load += new System.EventHandler(this.frmPretragaProizvoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.DataGridView dataGridViewPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Šifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}