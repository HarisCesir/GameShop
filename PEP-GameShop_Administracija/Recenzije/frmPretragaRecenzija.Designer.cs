namespace PEP_GameShop_Administracija.Recenzije
{
    partial class frmPretragaRecenzija
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
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.dataGridViewRecenzije = new System.Windows.Forms.DataGridView();
            this.buttonDetalji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(61, 6);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(237, 20);
            this.textBoxNaslov.TabIndex = 1;
            this.textBoxNaslov.TextChanged += new System.EventHandler(this.textBoxNaslov_TextChanged);
            // 
            // dataGridViewRecenzije
            // 
            this.dataGridViewRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecenzije.Location = new System.Drawing.Point(1, 54);
            this.dataGridViewRecenzije.Name = "dataGridViewRecenzije";
            this.dataGridViewRecenzije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecenzije.Size = new System.Drawing.Size(307, 204);
            this.dataGridViewRecenzije.TabIndex = 2;
            this.dataGridViewRecenzije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecenzije_CellClick);
            this.dataGridViewRecenzije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecenzije_CellContentClick);
            // 
            // buttonDetalji
            // 
            this.buttonDetalji.Location = new System.Drawing.Point(1, 32);
            this.buttonDetalji.Name = "buttonDetalji";
            this.buttonDetalji.Size = new System.Drawing.Size(75, 23);
            this.buttonDetalji.TabIndex = 3;
            this.buttonDetalji.Text = "Detalji";
            this.buttonDetalji.UseVisualStyleBackColor = true;
            this.buttonDetalji.Click += new System.EventHandler(this.buttonDetalji_Click);
            // 
            // frmPretragaRecenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 257);
            this.Controls.Add(this.buttonDetalji);
            this.Controls.Add(this.dataGridViewRecenzije);
            this.Controls.Add(this.textBoxNaslov);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPretragaRecenzija";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga recenzija";
            this.Load += new System.EventHandler(this.frmPretragaRecenzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaslov;
        private System.Windows.Forms.DataGridView dataGridViewRecenzije;
        private System.Windows.Forms.Button buttonDetalji;
    }
}