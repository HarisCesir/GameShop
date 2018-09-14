namespace PEP_GameShop_Administracija.Aukcija
{
    partial class frmAukcijePretragaPoDatumu
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
            this.datumOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumDO = new System.Windows.Forms.DateTimePicker();
            this.gridViewAukcijeDatum = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAukcijeDatum)).BeginInit();
            this.SuspendLayout();
            // 
            // datumOD
            // 
            this.datumOD.Location = new System.Drawing.Point(75, 12);
            this.datumOD.Name = "datumOD";
            this.datumOD.Size = new System.Drawing.Size(200, 20);
            this.datumOD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum do";
            // 
            // datumDO
            // 
            this.datumDO.Location = new System.Drawing.Point(75, 46);
            this.datumDO.Name = "datumDO";
            this.datumDO.Size = new System.Drawing.Size(200, 20);
            this.datumDO.TabIndex = 3;
            // 
            // gridViewAukcijeDatum
            // 
            this.gridViewAukcijeDatum.AllowUserToAddRows = false;
            this.gridViewAukcijeDatum.AllowUserToDeleteRows = false;
            this.gridViewAukcijeDatum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAukcijeDatum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naslov,
            this.datum,
            this.datumd,
            this.Cijena});
            this.gridViewAukcijeDatum.Location = new System.Drawing.Point(1, 92);
            this.gridViewAukcijeDatum.Name = "gridViewAukcijeDatum";
            this.gridViewAukcijeDatum.ReadOnly = true;
            this.gridViewAukcijeDatum.Size = new System.Drawing.Size(445, 200);
            this.gridViewAukcijeDatum.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naziv";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.DataPropertyName = "DatumOD";
            this.datum.HeaderText = "Datum OD";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // datumd
            // 
            this.datumd.DataPropertyName = "DatumDO";
            this.datumd.HeaderText = "Datum DO";
            this.datumd.Name = "datumd";
            this.datumd.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // frmAukcijePretragaPoDatumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridViewAukcijeDatum);
            this.Controls.Add(this.datumDO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumOD);
            this.MaximizeBox = false;
            this.Name = "frmAukcijePretragaPoDatumu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aukcije pretraga po datumu";
            this.Load += new System.EventHandler(this.frmAukcijePretragaPoDatumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAukcijeDatum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumDO;
        private System.Windows.Forms.DataGridView gridViewAukcijeDatum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}