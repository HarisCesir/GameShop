namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class frmPretragaPoCijeni
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
            this.cijenaVeca = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CijenaManja = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCijena = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Šifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cijena veća od:";
            // 
            // cijenaVeca
            // 
            this.cijenaVeca.Location = new System.Drawing.Point(100, 10);
            this.cijenaVeca.Mask = "00000";
            this.cijenaVeca.Name = "cijenaVeca";
            this.cijenaVeca.Size = new System.Drawing.Size(84, 20);
            this.cijenaVeca.TabIndex = 1;
            this.cijenaVeca.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cijena manja od:";
            // 
            // CijenaManja
            // 
            this.CijenaManja.Location = new System.Drawing.Point(339, 10);
            this.CijenaManja.Mask = "00000";
            this.CijenaManja.Name = "CijenaManja";
            this.CijenaManja.Size = new System.Drawing.Size(84, 20);
            this.CijenaManja.TabIndex = 4;
            this.CijenaManja.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "KM";
            // 
            // dataGridViewCijena
            // 
            this.dataGridViewCijena.AllowUserToAddRows = false;
            this.dataGridViewCijena.AllowUserToDeleteRows = false;
            this.dataGridViewCijena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCijena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Šifra,
            this.DatumIzdavanja,
            this.Cijena,
            this.Aktivan});
            this.dataGridViewCijena.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewCijena.Name = "dataGridViewCijena";
            this.dataGridViewCijena.ReadOnly = true;
            this.dataGridViewCijena.Size = new System.Drawing.Size(544, 196);
            this.dataGridViewCijena.TabIndex = 6;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Šifra
            // 
            this.Šifra.DataPropertyName = "Šifra";
            this.Šifra.HeaderText = "Šifra";
            this.Šifra.Name = "Šifra";
            this.Šifra.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Status";
            this.Aktivan.FalseValue = "0";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.TrueValue = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPretragaPoCijeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CijenaManja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cijenaVeca);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPretragaPoCijeni";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga po cijeni";
            this.Load += new System.EventHandler(this.frmPretragaPoCijeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox cijenaVeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CijenaManja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCijena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Šifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}