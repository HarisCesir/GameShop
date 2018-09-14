namespace PEP_GameShop_Administracija.Izlaz
{
    partial class frmIzlaz
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
            this.Narudžba = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.comboBoxNarudžba = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.textBoxPDv = new System.Windows.Forms.TextBox();
            this.textBoxIznos = new System.Windows.Forms.TextBox();
            this.textBoxBrojracuna = new System.Windows.Forms.TextBox();
            this.labelukupno = new System.Windows.Forms.Label();
            this.labelPDv = new System.Windows.Forms.Label();
            this.labelracun = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.dataGridViewIgre = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Narudžba.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIgre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Narudžba
            // 
            this.Narudžba.Controls.Add(this.dateTimePickerDatum);
            this.Narudžba.Controls.Add(this.textBoxPrezime);
            this.Narudžba.Controls.Add(this.textBoxIme);
            this.Narudžba.Controls.Add(this.comboBoxNarudžba);
            this.Narudžba.Controls.Add(this.label3);
            this.Narudžba.Controls.Add(this.label2);
            this.Narudžba.Controls.Add(this.label1);
            this.Narudžba.Controls.Add(this.labelIme);
            this.Narudžba.Location = new System.Drawing.Point(12, 12);
            this.Narudžba.Name = "Narudžba";
            this.Narudžba.Size = new System.Drawing.Size(330, 162);
            this.Narudžba.TabIndex = 0;
            this.Narudžba.TabStop = false;
            this.Narudžba.Text = "Narudžba";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Enabled = false;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(79, 108);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerDatum.TabIndex = 7;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(79, 80);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.ReadOnly = true;
            this.textBoxPrezime.Size = new System.Drawing.Size(223, 20);
            this.textBoxPrezime.TabIndex = 6;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(79, 53);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.ReadOnly = true;
            this.textBoxIme.Size = new System.Drawing.Size(223, 20);
            this.textBoxIme.TabIndex = 5;
            // 
            // comboBoxNarudžba
            // 
            this.comboBoxNarudžba.FormattingEnabled = true;
            this.comboBoxNarudžba.Location = new System.Drawing.Point(79, 25);
            this.comboBoxNarudžba.Name = "comboBoxNarudžba";
            this.comboBoxNarudžba.Size = new System.Drawing.Size(223, 21);
            this.comboBoxNarudžba.TabIndex = 4;
            this.comboBoxNarudžba.SelectedIndexChanged += new System.EventHandler(this.comboBoxNarudžba_SelectedIndexChanged);
            this.comboBoxNarudžba.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxNarudžba_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj narudžbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prezime:";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(7, 53);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxUkupno);
            this.groupBox1.Controls.Add(this.textBoxPDv);
            this.groupBox1.Controls.Add(this.textBoxIznos);
            this.groupBox1.Controls.Add(this.textBoxBrojracuna);
            this.groupBox1.Controls.Add(this.labelukupno);
            this.groupBox1.Controls.Add(this.labelPDv);
            this.groupBox1.Controls.Add(this.labelracun);
            this.groupBox1.Controls.Add(this.labelBroj);
            this.groupBox1.Location = new System.Drawing.Point(361, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Račun";
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(68, 56);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.ReadOnly = true;
            this.textBoxUkupno.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupno.TabIndex = 7;
            // 
            // textBoxPDv
            // 
            this.textBoxPDv.Location = new System.Drawing.Point(246, 53);
            this.textBoxPDv.Name = "textBoxPDv";
            this.textBoxPDv.ReadOnly = true;
            this.textBoxPDv.Size = new System.Drawing.Size(90, 20);
            this.textBoxPDv.TabIndex = 6;
            // 
            // textBoxIznos
            // 
            this.textBoxIznos.Location = new System.Drawing.Point(254, 18);
            this.textBoxIznos.Name = "textBoxIznos";
            this.textBoxIznos.ReadOnly = true;
            this.textBoxIznos.Size = new System.Drawing.Size(82, 20);
            this.textBoxIznos.TabIndex = 5;
            // 
            // textBoxBrojracuna
            // 
            this.textBoxBrojracuna.Location = new System.Drawing.Point(77, 20);
            this.textBoxBrojracuna.Name = "textBoxBrojracuna";
            this.textBoxBrojracuna.Size = new System.Drawing.Size(124, 20);
            this.textBoxBrojracuna.TabIndex = 4;
            this.textBoxBrojracuna.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBrojracuna_Validating);
            // 
            // labelukupno
            // 
            this.labelukupno.AutoSize = true;
            this.labelukupno.Location = new System.Drawing.Point(13, 60);
            this.labelukupno.Name = "labelukupno";
            this.labelukupno.Size = new System.Drawing.Size(48, 13);
            this.labelukupno.TabIndex = 3;
            this.labelukupno.Text = "Ukupno:";
            // 
            // labelPDv
            // 
            this.labelPDv.AutoSize = true;
            this.labelPDv.Location = new System.Drawing.Point(208, 56);
            this.labelPDv.Name = "labelPDv";
            this.labelPDv.Size = new System.Drawing.Size(32, 13);
            this.labelPDv.TabIndex = 2;
            this.labelPDv.Text = "PDV:";
            // 
            // labelracun
            // 
            this.labelracun.AutoSize = true;
            this.labelracun.Location = new System.Drawing.Point(213, 21);
            this.labelracun.Name = "labelracun";
            this.labelracun.Size = new System.Drawing.Size(35, 13);
            this.labelracun.TabIndex = 1;
            this.labelracun.Text = "Iznos:";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(6, 25);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(64, 13);
            this.labelBroj.TabIndex = 0;
            this.labelBroj.Text = "Broj računa:";
            // 
            // dataGridViewIgre
            // 
            this.dataGridViewIgre.AllowUserToAddRows = false;
            this.dataGridViewIgre.AllowUserToDeleteRows = false;
            this.dataGridViewIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIgre.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewIgre.Name = "dataGridViewIgre";
            this.dataGridViewIgre.ReadOnly = true;
            this.dataGridViewIgre.Size = new System.Drawing.Size(691, 150);
            this.dataGridViewIgre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zaključi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIzlaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewIgre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Narudžba);
            this.MaximizeBox = false;
            this.Name = "frmIzlaz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izlaz";
            this.Load += new System.EventHandler(this.frmIzlaz_Load);
            this.Narudžba.ResumeLayout(false);
            this.Narudžba.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIgre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Narudžba;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.ComboBox comboBoxNarudžba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewIgre;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.TextBox textBoxPDv;
        private System.Windows.Forms.TextBox textBoxIznos;
        private System.Windows.Forms.TextBox textBoxBrojracuna;
        private System.Windows.Forms.Label labelukupno;
        private System.Windows.Forms.Label labelPDv;
        private System.Windows.Forms.Label labelracun;
        private System.Windows.Forms.Label labelBroj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}