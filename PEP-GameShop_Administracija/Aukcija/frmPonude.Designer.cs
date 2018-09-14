namespace PEP_GameShop_Administracija.Aukcija
{
    partial class frmPonude
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
            this.comboBoxIgre = new System.Windows.Forms.ComboBox();
            this.ponudeInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ponuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datumponude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ponudeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igra:";
            // 
            // comboBoxIgre
            // 
            this.comboBoxIgre.FormattingEnabled = true;
            this.comboBoxIgre.Location = new System.Drawing.Point(51, 19);
            this.comboBoxIgre.Name = "comboBoxIgre";
            this.comboBoxIgre.Size = new System.Drawing.Size(188, 21);
            this.comboBoxIgre.TabIndex = 1;
            // 
            // ponudeInfo
            // 
            this.ponudeInfo.AllowUserToAddRows = false;
            this.ponudeInfo.AllowUserToDeleteRows = false;
            this.ponudeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ponudeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.Ponuda,
            this.Datumponude});
            this.ponudeInfo.Location = new System.Drawing.Point(-1, 55);
            this.ponudeInfo.MultiSelect = false;
            this.ponudeInfo.Name = "ponudeInfo";
            this.ponudeInfo.ReadOnly = true;
            this.ponudeInfo.Size = new System.Drawing.Size(350, 199);
            this.ponudeInfo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prikaži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kupac
            // 
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            // 
            // Ponuda
            // 
            this.Ponuda.DataPropertyName = "Ponuda";
            this.Ponuda.HeaderText = "Ponuda";
            this.Ponuda.Name = "Ponuda";
            this.Ponuda.ReadOnly = true;
            // 
            // Datumponude
            // 
            this.Datumponude.DataPropertyName = "DatumPonude";
            this.Datumponude.HeaderText = "Datum ponude";
            this.Datumponude.Name = "Datumponude";
            this.Datumponude.ReadOnly = true;
            // 
            // frmPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ponudeInfo);
            this.Controls.Add(this.comboBoxIgre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPonude";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponude";
            this.Load += new System.EventHandler(this.frmPonude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ponudeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIgre;
        private System.Windows.Forms.DataGridView ponudeInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datumponude;
    }
}