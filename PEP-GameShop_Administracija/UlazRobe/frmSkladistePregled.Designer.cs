namespace PEP_GameShop_Administracija.UlazRobe
{
    partial class frmSkladistePregled
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
            this.comboBoxSkladište = new System.Windows.Forms.ComboBox();
            this.dataGridViewPregledSkladišta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledSkladišta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skladište:";
            // 
            // comboBoxSkladište
            // 
            this.comboBoxSkladište.FormattingEnabled = true;
            this.comboBoxSkladište.Location = new System.Drawing.Point(73, 10);
            this.comboBoxSkladište.Name = "comboBoxSkladište";
            this.comboBoxSkladište.Size = new System.Drawing.Size(207, 21);
            this.comboBoxSkladište.TabIndex = 1;
            this.comboBoxSkladište.SelectedIndexChanged += new System.EventHandler(this.comboBoxSkladište_SelectedIndexChanged);
            // 
            // dataGridViewPregledSkladišta
            // 
            this.dataGridViewPregledSkladišta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPregledSkladišta.Location = new System.Drawing.Point(1, 46);
            this.dataGridViewPregledSkladišta.Name = "dataGridViewPregledSkladišta";
            this.dataGridViewPregledSkladišta.Size = new System.Drawing.Size(495, 193);
            this.dataGridViewPregledSkladišta.TabIndex = 2;
            // 
            // frmSkladistePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 240);
            this.Controls.Add(this.dataGridViewPregledSkladišta);
            this.Controls.Add(this.comboBoxSkladište);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSkladistePregled";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled skladišta";
            this.Load += new System.EventHandler(this.frmSkladistePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledSkladišta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSkladište;
        private System.Windows.Forms.DataGridView dataGridViewPregledSkladišta;
    }
}