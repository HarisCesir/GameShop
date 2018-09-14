namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class frmProizvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProizvodi));
            this.labelVrsta = new System.Windows.Forms.Label();
            this.labelSifra = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.labelIzdavac = new System.Windows.Forms.Label();
            this.comboBoxIzdavaci = new System.Windows.Forms.ComboBox();
            this.labelDatumIzdavanja = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelTrailer = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.labelKM = new System.Windows.Forms.Label();
            this.textBoxTrailer = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.labelSlika = new System.Windows.Forms.Label();
            this.textBoxSlika = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IgraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.openFileDialogSlika = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Location = new System.Drawing.Point(60, 15);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(34, 13);
            this.labelVrsta.TabIndex = 0;
            this.labelVrsta.Text = "Vrsta:";
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(63, 89);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(31, 13);
            this.labelSifra.TabIndex = 1;
            this.labelSifra.Text = "Šifra:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(57, 121);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 2;
            this.labelNaziv.Text = "Naziv:";
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(100, 12);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(178, 21);
            this.comboBoxVrsta.TabIndex = 3;
            this.comboBoxVrsta.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxVrsta_Validating);
            // 
            // labelIzdavac
            // 
            this.labelIzdavac.AutoSize = true;
            this.labelIzdavac.Location = new System.Drawing.Point(49, 50);
            this.labelIzdavac.Name = "labelIzdavac";
            this.labelIzdavac.Size = new System.Drawing.Size(48, 13);
            this.labelIzdavac.TabIndex = 4;
            this.labelIzdavac.Text = "Izdavač:";
            // 
            // comboBoxIzdavaci
            // 
            this.comboBoxIzdavaci.FormattingEnabled = true;
            this.comboBoxIzdavaci.Location = new System.Drawing.Point(100, 50);
            this.comboBoxIzdavaci.Name = "comboBoxIzdavaci";
            this.comboBoxIzdavaci.Size = new System.Drawing.Size(178, 21);
            this.comboBoxIzdavaci.TabIndex = 5;
            this.comboBoxIzdavaci.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxIzdavaci_Validating);
            // 
            // labelDatumIzdavanja
            // 
            this.labelDatumIzdavanja.AutoSize = true;
            this.labelDatumIzdavanja.Location = new System.Drawing.Point(8, 150);
            this.labelDatumIzdavanja.Name = "labelDatumIzdavanja";
            this.labelDatumIzdavanja.Size = new System.Drawing.Size(89, 13);
            this.labelDatumIzdavanja.TabIndex = 6;
            this.labelDatumIzdavanja.Text = "Datum izdavanja:";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(58, 253);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(39, 13);
            this.labelCijena.TabIndex = 7;
            this.labelCijena.Text = "Cijena:";
            // 
            // labelTrailer
            // 
            this.labelTrailer.AutoSize = true;
            this.labelTrailer.Location = new System.Drawing.Point(60, 283);
            this.labelTrailer.Name = "labelTrailer";
            this.labelTrailer.Size = new System.Drawing.Size(39, 13);
            this.labelTrailer.TabIndex = 8;
            this.labelTrailer.Text = "Trailer:";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(317, 249);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(31, 13);
            this.labelOpis.TabIndex = 9;
            this.labelOpis.Text = "Opis:";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(100, 86);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(178, 20);
            this.textBoxSifra.TabIndex = 10;
            this.textBoxSifra.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSifra_Validating);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(100, 118);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(178, 20);
            this.textBoxNaziv.TabIndex = 11;
            this.textBoxNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNaziv_Validating);
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(100, 144);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerDatum.TabIndex = 12;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(100, 250);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(76, 20);
            this.textBoxCijena.TabIndex = 13;
            this.textBoxCijena.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCijena_Validating);
            // 
            // labelKM
            // 
            this.labelKM.AutoSize = true;
            this.labelKM.Location = new System.Drawing.Point(182, 253);
            this.labelKM.Name = "labelKM";
            this.labelKM.Size = new System.Drawing.Size(23, 13);
            this.labelKM.TabIndex = 14;
            this.labelKM.Text = "KM";
            // 
            // textBoxTrailer
            // 
            this.textBoxTrailer.Location = new System.Drawing.Point(100, 283);
            this.textBoxTrailer.Name = "textBoxTrailer";
            this.textBoxTrailer.Size = new System.Drawing.Size(248, 20);
            this.textBoxTrailer.TabIndex = 15;
            this.textBoxTrailer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTrailer_Validating);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(357, 249);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(225, 70);
            this.textBoxOpis.TabIndex = 16;
            // 
            // labelSlika
            // 
            this.labelSlika.AutoSize = true;
            this.labelSlika.Location = new System.Drawing.Point(49, 369);
            this.labelSlika.Name = "labelSlika";
            this.labelSlika.Size = new System.Drawing.Size(33, 13);
            this.labelSlika.TabIndex = 17;
            this.labelSlika.Text = "Slika:";
            // 
            // textBoxSlika
            // 
            this.textBoxSlika.Location = new System.Drawing.Point(100, 366);
            this.textBoxSlika.Name = "textBoxSlika";
            this.textBoxSlika.Size = new System.Drawing.Size(227, 20);
            this.textBoxSlika.TabIndex = 18;
            this.textBoxSlika.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSlika_Validating);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(333, 364);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 19;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(507, 384);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(75, 31);
            this.buttonSacuvaj.TabIndex = 21;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IgraID,
            this.Naziv,
            this.Sifra,
            this.Datum,
            this.Cijena,
            this.SlikaThumb,
            this.Opis,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 421);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(622, 190);
            this.dataGridView1.TabIndex = 22;
            // 
            // IgraID
            // 
            this.IgraID.DataPropertyName = "IgraID";
            this.IgraID.HeaderText = "IgraID";
            this.IgraID.Name = "IgraID";
            this.IgraID.ReadOnly = true;
            this.IgraID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Šifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumIzdavanja";
            this.Datum.HeaderText = "Datum Izdavanja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika Thumb";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Aktivan";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // openFileDialogSlika
            // 
            this.openFileDialogSlika.FileName = "openFileDialog1";
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.Location = new System.Drawing.Point(357, 15);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(200, 180);
            this.pictureBoxSlika.TabIndex = 20;
            this.pictureBoxSlika.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.pictureBoxSlika);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxSlika);
            this.Controls.Add(this.labelSlika);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxTrailer);
            this.Controls.Add(this.labelKM);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelTrailer);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelDatumIzdavanja);
            this.Controls.Add(this.comboBoxIzdavaci);
            this.Controls.Add(this.labelIzdavac);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.labelVrsta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProizvodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.Label labelIzdavac;
        private System.Windows.Forms.ComboBox comboBoxIzdavaci;
        private System.Windows.Forms.Label labelDatumIzdavanja;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelTrailer;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label labelKM;
        private System.Windows.Forms.TextBox textBoxTrailer;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label labelSlika;
        private System.Windows.Forms.TextBox textBoxSlika;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialogSlika;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}