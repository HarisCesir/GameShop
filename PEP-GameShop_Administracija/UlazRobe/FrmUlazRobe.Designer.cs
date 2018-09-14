namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class FrmUlazRobe
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
            this.groupBoxDobavljač = new System.Windows.Forms.GroupBox();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxKontaktOsoba = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelKontaktOsoba = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.groupBoxUlaznaFaktura = new System.Windows.Forms.GroupBox();
            this.buttonDodajSkladista = new System.Windows.Forms.Button();
            this.comboBoxSkladiste = new System.Windows.Forms.ComboBox();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.textBoxPDV = new System.Windows.Forms.TextBox();
            this.textBoxRacun = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxBrojFakture = new System.Windows.Forms.TextBox();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.labelPDV = new System.Windows.Forms.Label();
            this.labelIznosRacuna = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelBrojFakture = new System.Windows.Forms.Label();
            this.labelSkladiste = new System.Windows.Forms.Label();
            this.groupBoxStavke = new System.Windows.Forms.GroupBox();
            this.buttonzakljuci = new System.Windows.Forms.Button();
            this.dataGridViewIgre = new System.Windows.Forms.DataGridView();
            this.IgraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelCijena = new System.Windows.Forms.Label();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.textBoxSifraProizvoda = new System.Windows.Forms.TextBox();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.labelSifraProizvoda = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDobavljač.SuspendLayout();
            this.groupBoxUlaznaFaktura.SuspendLayout();
            this.groupBoxStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIgre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDobavljač
            // 
            this.groupBoxDobavljač.Controls.Add(this.buttonPretraga);
            this.groupBoxDobavljač.Controls.Add(this.textBoxTelefon);
            this.groupBoxDobavljač.Controls.Add(this.textBoxKontaktOsoba);
            this.groupBoxDobavljač.Controls.Add(this.textBoxNaziv);
            this.groupBoxDobavljač.Controls.Add(this.labelTelefon);
            this.groupBoxDobavljač.Controls.Add(this.labelKontaktOsoba);
            this.groupBoxDobavljač.Controls.Add(this.labelNaziv);
            this.groupBoxDobavljač.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDobavljač.Name = "groupBoxDobavljač";
            this.groupBoxDobavljač.Size = new System.Drawing.Size(617, 121);
            this.groupBoxDobavljač.TabIndex = 0;
            this.groupBoxDobavljač.TabStop = false;
            this.groupBoxDobavljač.Text = "Dobavljač";
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.Location = new System.Drawing.Point(311, 66);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(108, 38);
            this.buttonPretraga.TabIndex = 6;
            this.buttonPretraga.Text = "Pretraga";
            this.buttonPretraga.UseVisualStyleBackColor = true;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(97, 84);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.ReadOnly = true;
            this.textBoxTelefon.Size = new System.Drawing.Size(188, 20);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxKontaktOsoba
            // 
            this.textBoxKontaktOsoba.Location = new System.Drawing.Point(97, 58);
            this.textBoxKontaktOsoba.Name = "textBoxKontaktOsoba";
            this.textBoxKontaktOsoba.ReadOnly = true;
            this.textBoxKontaktOsoba.Size = new System.Drawing.Size(188, 20);
            this.textBoxKontaktOsoba.TabIndex = 4;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(97, 26);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.ReadOnly = true;
            this.textBoxNaziv.Size = new System.Drawing.Size(188, 20);
            this.textBoxNaziv.TabIndex = 3;
            this.textBoxNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNaziv_Validating);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(54, 87);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelTelefon.TabIndex = 2;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelKontaktOsoba
            // 
            this.labelKontaktOsoba.AutoSize = true;
            this.labelKontaktOsoba.Location = new System.Drawing.Point(21, 61);
            this.labelKontaktOsoba.Name = "labelKontaktOsoba";
            this.labelKontaktOsoba.Size = new System.Drawing.Size(79, 13);
            this.labelKontaktOsoba.TabIndex = 1;
            this.labelKontaktOsoba.Text = "Kontakt osoba:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(54, 29);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // groupBoxUlaznaFaktura
            // 
            this.groupBoxUlaznaFaktura.Controls.Add(this.buttonDodajSkladista);
            this.groupBoxUlaznaFaktura.Controls.Add(this.comboBoxSkladiste);
            this.groupBoxUlaznaFaktura.Controls.Add(this.textBoxNapomena);
            this.groupBoxUlaznaFaktura.Controls.Add(this.textBoxPDV);
            this.groupBoxUlaznaFaktura.Controls.Add(this.textBoxRacun);
            this.groupBoxUlaznaFaktura.Controls.Add(this.dateTimePickerDatum);
            this.groupBoxUlaznaFaktura.Controls.Add(this.textBoxBrojFakture);
            this.groupBoxUlaznaFaktura.Controls.Add(this.labelNapomena);
            this.groupBoxUlaznaFaktura.Controls.Add(this.labelPDV);
            this.groupBoxUlaznaFaktura.Controls.Add(this.labelIznosRacuna);
            this.groupBoxUlaznaFaktura.Controls.Add(this.labelDatum);
            this.groupBoxUlaznaFaktura.Controls.Add(this.labelBrojFakture);
            this.groupBoxUlaznaFaktura.Controls.Add(this.labelSkladiste);
            this.groupBoxUlaznaFaktura.Location = new System.Drawing.Point(12, 164);
            this.groupBoxUlaznaFaktura.Name = "groupBoxUlaznaFaktura";
            this.groupBoxUlaznaFaktura.Size = new System.Drawing.Size(617, 159);
            this.groupBoxUlaznaFaktura.TabIndex = 1;
            this.groupBoxUlaznaFaktura.TabStop = false;
            this.groupBoxUlaznaFaktura.Text = "Ulazna faktura";
            // 
            // buttonDodajSkladista
            // 
            this.buttonDodajSkladista.Location = new System.Drawing.Point(291, 23);
            this.buttonDodajSkladista.Name = "buttonDodajSkladista";
            this.buttonDodajSkladista.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajSkladista.TabIndex = 13;
            this.buttonDodajSkladista.Text = "Dodaj";
            this.buttonDodajSkladista.UseVisualStyleBackColor = true;
            this.buttonDodajSkladista.Click += new System.EventHandler(this.buttonDodajSkladista_Click);
            // 
            // comboBoxSkladiste
            // 
            this.comboBoxSkladiste.FormattingEnabled = true;
            this.comboBoxSkladiste.Location = new System.Drawing.Point(80, 25);
            this.comboBoxSkladiste.Name = "comboBoxSkladiste";
            this.comboBoxSkladiste.Size = new System.Drawing.Size(205, 21);
            this.comboBoxSkladiste.TabIndex = 12;
            this.comboBoxSkladiste.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSkladiste_Validating);
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(440, 25);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(171, 100);
            this.textBoxNapomena.TabIndex = 11;
            // 
            // textBoxPDV
            // 
            this.textBoxPDV.Location = new System.Drawing.Point(224, 120);
            this.textBoxPDV.Name = "textBoxPDV";
            this.textBoxPDV.ReadOnly = true;
            this.textBoxPDV.Size = new System.Drawing.Size(61, 20);
            this.textBoxPDV.TabIndex = 10;
            // 
            // textBoxRacun
            // 
            this.textBoxRacun.Location = new System.Drawing.Point(80, 120);
            this.textBoxRacun.Name = "textBoxRacun";
            this.textBoxRacun.ReadOnly = true;
            this.textBoxRacun.Size = new System.Drawing.Size(100, 20);
            this.textBoxRacun.TabIndex = 9;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(80, 86);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerDatum.TabIndex = 8;
            // 
            // textBoxBrojFakture
            // 
            this.textBoxBrojFakture.Location = new System.Drawing.Point(80, 59);
            this.textBoxBrojFakture.Name = "textBoxBrojFakture";
            this.textBoxBrojFakture.Size = new System.Drawing.Size(205, 20);
            this.textBoxBrojFakture.TabIndex = 7;
            this.textBoxBrojFakture.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBrojFakture_Validating);
            // 
            // labelNapomena
            // 
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Location = new System.Drawing.Point(372, 33);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(62, 13);
            this.labelNapomena.TabIndex = 5;
            this.labelNapomena.Text = "Napomena:";
            // 
            // labelPDV
            // 
            this.labelPDV.AutoSize = true;
            this.labelPDV.Location = new System.Drawing.Point(186, 123);
            this.labelPDV.Name = "labelPDV";
            this.labelPDV.Size = new System.Drawing.Size(32, 13);
            this.labelPDV.TabIndex = 4;
            this.labelPDV.Text = "PDV:";
            // 
            // labelIznosRacuna
            // 
            this.labelIznosRacuna.AutoSize = true;
            this.labelIznosRacuna.Location = new System.Drawing.Point(3, 123);
            this.labelIznosRacuna.Name = "labelIznosRacuna";
            this.labelIznosRacuna.Size = new System.Drawing.Size(71, 13);
            this.labelIznosRacuna.TabIndex = 3;
            this.labelIznosRacuna.Text = "Iznos računa:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(33, 92);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(41, 13);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "Datum:";
            // 
            // labelBrojFakture
            // 
            this.labelBrojFakture.AutoSize = true;
            this.labelBrojFakture.Location = new System.Drawing.Point(10, 62);
            this.labelBrojFakture.Name = "labelBrojFakture";
            this.labelBrojFakture.Size = new System.Drawing.Size(64, 13);
            this.labelBrojFakture.TabIndex = 1;
            this.labelBrojFakture.Text = "Broj fakture:";
            // 
            // labelSkladiste
            // 
            this.labelSkladiste.AutoSize = true;
            this.labelSkladiste.Location = new System.Drawing.Point(21, 28);
            this.labelSkladiste.Name = "labelSkladiste";
            this.labelSkladiste.Size = new System.Drawing.Size(53, 13);
            this.labelSkladiste.TabIndex = 0;
            this.labelSkladiste.Text = "Skladište:";
            // 
            // groupBoxStavke
            // 
            this.groupBoxStavke.Controls.Add(this.buttonzakljuci);
            this.groupBoxStavke.Controls.Add(this.dataGridViewIgre);
            this.groupBoxStavke.Controls.Add(this.buttonDodaj);
            this.groupBoxStavke.Controls.Add(this.labelCijena);
            this.groupBoxStavke.Controls.Add(this.textBoxCijena);
            this.groupBoxStavke.Controls.Add(this.textBoxKolicina);
            this.groupBoxStavke.Controls.Add(this.textBoxSifraProizvoda);
            this.groupBoxStavke.Controls.Add(this.labelKolicina);
            this.groupBoxStavke.Controls.Add(this.labelSifraProizvoda);
            this.groupBoxStavke.Location = new System.Drawing.Point(12, 329);
            this.groupBoxStavke.Name = "groupBoxStavke";
            this.groupBoxStavke.Size = new System.Drawing.Size(617, 252);
            this.groupBoxStavke.TabIndex = 2;
            this.groupBoxStavke.TabStop = false;
            this.groupBoxStavke.Text = "Stavke";
            // 
            // buttonzakljuci
            // 
            this.buttonzakljuci.Location = new System.Drawing.Point(406, 164);
            this.buttonzakljuci.Name = "buttonzakljuci";
            this.buttonzakljuci.Size = new System.Drawing.Size(94, 50);
            this.buttonzakljuci.TabIndex = 8;
            this.buttonzakljuci.Text = "Zaključi";
            this.buttonzakljuci.UseVisualStyleBackColor = true;
            this.buttonzakljuci.Click += new System.EventHandler(this.buttonzakljuci_Click);
            // 
            // dataGridViewIgre
            // 
            this.dataGridViewIgre.AllowUserToAddRows = false;
            this.dataGridViewIgre.AllowUserToDeleteRows = false;
            this.dataGridViewIgre.AllowUserToOrderColumns = true;
            this.dataGridViewIgre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIgre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IgraID,
            this.Igra,
            this.Količina,
            this.Cijena});
            this.dataGridViewIgre.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewIgre.Location = new System.Drawing.Point(21, 96);
            this.dataGridViewIgre.MultiSelect = false;
            this.dataGridViewIgre.Name = "dataGridViewIgre";
            this.dataGridViewIgre.ReadOnly = true;
            this.dataGridViewIgre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIgre.Size = new System.Drawing.Size(345, 150);
            this.dataGridViewIgre.TabIndex = 7;
            this.dataGridViewIgre.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridViewIgre_Validating);
            // 
            // IgraID
            // 
            this.IgraID.HeaderText = "IgraID";
            this.IgraID.Name = "IgraID";
            this.IgraID.ReadOnly = true;
            this.IgraID.Visible = false;
            // 
            // Igra
            // 
            this.Igra.DataPropertyName = "Igre";
            this.Igra.HeaderText = "Igra";
            this.Igra.Name = "Igra";
            this.Igra.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Kolicina";
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(329, 53);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(186, 57);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(39, 13);
            this.labelCijena.TabIndex = 5;
            this.labelCijena.Text = "Cijena:";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(224, 53);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(89, 20);
            this.textBoxCijena.TabIndex = 4;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(104, 50);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(76, 20);
            this.textBoxKolicina.TabIndex = 3;
            // 
            // textBoxSifraProizvoda
            // 
            this.textBoxSifraProizvoda.Location = new System.Drawing.Point(104, 23);
            this.textBoxSifraProizvoda.Name = "textBoxSifraProizvoda";
            this.textBoxSifraProizvoda.Size = new System.Drawing.Size(209, 20);
            this.textBoxSifraProizvoda.TabIndex = 2;
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(51, 53);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(47, 13);
            this.labelKolicina.TabIndex = 1;
            this.labelKolicina.Text = "Količina:";
            // 
            // labelSifraProizvoda
            // 
            this.labelSifraProizvoda.AutoSize = true;
            this.labelSifraProizvoda.Location = new System.Drawing.Point(18, 23);
            this.labelSifraProizvoda.Name = "labelSifraProizvoda";
            this.labelSifraProizvoda.Size = new System.Drawing.Size(80, 13);
            this.labelSifraProizvoda.TabIndex = 0;
            this.labelSifraProizvoda.Text = "Šifra proizvoda:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUlazRobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 593);
            this.Controls.Add(this.groupBoxStavke);
            this.Controls.Add(this.groupBoxUlaznaFaktura);
            this.Controls.Add(this.groupBoxDobavljač);
            this.MaximizeBox = false;
            this.Name = "FrmUlazRobe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulaz robe";
            this.Load += new System.EventHandler(this.FrmUlazRobe_Load);
            this.groupBoxDobavljač.ResumeLayout(false);
            this.groupBoxDobavljač.PerformLayout();
            this.groupBoxUlaznaFaktura.ResumeLayout(false);
            this.groupBoxUlaznaFaktura.PerformLayout();
            this.groupBoxStavke.ResumeLayout(false);
            this.groupBoxStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIgre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDobavljač;
        private System.Windows.Forms.Button buttonPretraga;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxKontaktOsoba;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelKontaktOsoba;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.GroupBox groupBoxUlaznaFaktura;
        private System.Windows.Forms.ComboBox comboBoxSkladiste;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.TextBox textBoxPDV;
        private System.Windows.Forms.TextBox textBoxRacun;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxBrojFakture;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.Label labelPDV;
        private System.Windows.Forms.Label labelIznosRacuna;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelBrojFakture;
        private System.Windows.Forms.Label labelSkladiste;
        private System.Windows.Forms.GroupBox groupBoxStavke;
        private System.Windows.Forms.DataGridView dataGridViewIgre;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxSifraProizvoda;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.Label labelSifraProizvoda;
        private System.Windows.Forms.Button buttonzakljuci;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button buttonDodajSkladista;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}